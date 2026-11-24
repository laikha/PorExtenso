using ExtensoSuporte.Model;
using ExtensoSuporte;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace PorExtenso.Controllers.Tests
{
    public class ValuesControllerTests
    {
        [Test]
        public void Test_SemNumero_RetornaBadRequestComErro()
        {
            ValuesController valuesController = new();

            IActionResult ret = valuesController.Get();

            Assert.IsInstanceOf<BadRequestObjectResult>(ret);
            var result = (BadRequestObjectResult)ret;
            Numeral numeral = ValuesController.FromJson<Numeral>(result.Value.ToString());
            Assert.AreEqual(400, result.StatusCode);
            Assert.IsNotEmpty(numeral.Erro);
        }

        [TestCase(-1000000)]
        [TestCase(1000000)]
        public void Test_ForaDosLimites_RetornaBadRequestComErro(int numero)
        {
            ValuesController valuesController = new();

            IActionResult ret = valuesController.Get(numero);

            Assert.IsInstanceOf<BadRequestObjectResult>(ret);
            var result = (BadRequestObjectResult)ret;
            Numeral numeral = ValuesController.FromJson<Numeral>(result.Value.ToString());
            Assert.AreEqual(400, result.StatusCode);
            Assert.IsNotEmpty(numeral.Erro);
            Assert.IsNull(numeral.Extenso);
        }

        [TestCase(-999999)]
        [TestCase(999999)]
        public void Test_LimitesInclusivos_RetornaOk(int numero)
        {
            ValuesController valuesController = new();

            IActionResult ret = valuesController.Get(numero);

            Assert.IsInstanceOf<OkObjectResult>(ret);
            var result = (OkObjectResult)ret;
            Numeral numeral = ValuesController.FromJson<Numeral>(result.Value.ToString());
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(numero, numeral.Numero);
            Assert.IsNull(numeral.Erro);
        }

        [TestCase(1, "Um")]
        [TestCase(-21, "Menos Vinte e Um")]
        [TestCase(20000, "Vinte Mil")]
        public void Test_NumeroValido_RetornaExtenso(int numero, string expected)
        {
            ValuesController valuesController = new();

            IActionResult ret = valuesController.Get(numero);

            Assert.IsInstanceOf<OkObjectResult>(ret);
            var result = (OkObjectResult)ret;
            Numeral numeral = ValuesController.FromJson<Numeral>(result.Value.ToString());
            Assert.AreEqual(numero, numeral.Numero);
            Assert.AreEqual(expected, numeral.Extenso);
        }

        [Test]
        [Category("ValidadeSuporte")]
        [Description("Teste de chamada para não aceitar fora do range")]
        public void Test_NaoAceitarMaiorQueLimiteDeRange_Sucesso()
        {
           ValuesController valuesController = new();
            var ret = valuesController.Get(1000000);
            var expected = 400;
            Assert.AreEqual(expected, ((BadRequestObjectResult)ret).StatusCode);
        }

        [Test]
        [Category("ValidadeSuporte")]
        [Description("Teste de cardinal para tratar zero")]
        public void Test_ValidadeSuporte_Zero_Sucesso()
        {
            var number = 0;
            string textExpected = "Zero";

            ValuesController valuesController = new();
            IActionResult ret = valuesController.Get(number);

            var result = ((OkObjectResult)ret).Value;
            Numeral numeral = ValuesController.FromJson<Numeral>(result.ToString());

            string textReturned = numeral.Extenso;
            var numberReturned = numeral.Numero;

            bool test1 = textExpected.Equals(textReturned);
            bool test2 = numberReturned.Equals(number);

            Assert.IsTrue(test1 && test2);

        }

    }
}