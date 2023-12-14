using ExtensoSuporte.Model;
using ExtensoSuporte;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace PorExtenso.Controllers.Tests
{
    public class ValuesControllerTests
    {
        [Test]
        [Category("ValuesController")]
        [Description("Teste de chamada para não aceitar fora do range")]
        public void Test_NaoAceitarMaiorQueLimiteDeRange_Sucesso()
        {
           ValuesController valuesController = new();
            var ret = valuesController.Get(1000000);
            var expected = 400;
            Assert.AreEqual(expected, ((BadRequestObjectResult)ret).StatusCode);
        }

        [Test]
        [Category("ValuesController")]
        [Description("Teste de chamada para não aceitar fora do range")]
        public void Test_RetornoVazio_Sucesso()
        {
            ValuesController valuesController = new();
            var ret = valuesController.Get();
            var expected = 400;
            Assert.AreEqual(expected, ((BadRequestObjectResult)ret).StatusCode);
        }


        [Test]
        [Category("ValuesController")]
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

        [Test]
        [Category("ValuesController")]
        [Description("Teste de cardinal para tratar zero")]
        public void Test_ValidadeSuporte_Erro_Sucesso()
        {
            var number = 0;

            ValuesController valuesController = new();
            IActionResult ret = valuesController.Get(number);

            var result = ((OkObjectResult)ret).Value;
            Numeral numeral = ValuesController.FromJson<Numeral>(result.ToString());

            string textReturned = numeral.Erro;

            Assert.IsNull(textReturned);

        }

    }
}