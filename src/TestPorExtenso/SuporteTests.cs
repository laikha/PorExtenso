using ExtensoSuporte;
using ExtensoSuporte.Model;
using NUnit.Framework;

namespace Tests
{
    public class SuporteTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [Category("ObjectCreateTest")]
        [Description("Teste de cardinal para tratar milhar")]
        public void Test_ValidadeSuporte_NotNull_Sucesso()
        {
            Suporte<Numeral> suporte = new();

            suporte.GetDI().Numero = 1000;
            string ret = suporte.GetDI().ToJson();
            Assert.IsNotEmpty(ret);

        }

        [Test]
        [Category("Cardinal")]
        [Description("Teste de cardinal para tratar unidade")]
        public void Test_UnidadeCardinal_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 6;
            var ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Seis";
            Assert.AreEqual(expected, ret);
        }

        [TestCase(0, "Zero")]
        [TestCase(-1, "Menos Um")]
        [TestCase(-11, "Menos Onze")]
        [TestCase(-21, "Menos Vinte e Um")]
        [TestCase(-100, "Menos Cem")]
        [TestCase(-101, "Menos Cento e Um")]
        [TestCase(-2000, "Menos Dois Mil")]
        [Category("Cardinal")]
        public void Test_CardinalZeroENegativos(int numero, string expected)
        {
            Suporte<Numeral> suporte = new();

            string ret = suporte.GetCardinal(numero);

            Assert.AreEqual(expected, ret);
        }

        [TestCase(1000, "Mil")]
        [TestCase(1001, "Mil e Um")]
        [TestCase(1100, "Mil e Cem")]
        [TestCase(1101, "Mil Cento e Um")]
        [TestCase(2000, "Dois Mil")]
        [TestCase(10000, "Dez Mil")]
        [TestCase(20000, "Vinte Mil")]
        [TestCase(100000, "Cem Mil")]
        [TestCase(101000, "Cento e Um Mil")]
        [TestCase(129996, "Cento e Vinte e Nove Mil Novecentos e Noventa e Seis")]
        [TestCase(999999, "Novecentos e Noventa e Nove Mil Novecentos e Noventa e Nove")]
        [TestCase(-999999, "Menos Novecentos e Noventa e Nove Mil Novecentos e Noventa e Nove")]
        [Category("CardinalMilhar")]
        public void Test_CardinalMilhares(int numero, string expected)
        {
            Suporte<Numeral> suporte = new();

            string ret = suporte.GetCardinal(numero);

            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void Test_CardinalAtualizaSinalEntreChamadas()
        {
            Suporte<Numeral> suporte = new();

            Assert.AreEqual("Menos Vinte e Um", suporte.GetCardinal(-21));
            Assert.IsTrue(suporte.TemNegativo);
            Assert.AreEqual("Zero", suporte.GetCardinal(0));
            Assert.IsFalse(suporte.TemNegativo);
            Assert.AreEqual("Vinte e Um", suporte.GetCardinal(21));
            Assert.IsFalse(suporte.TemNegativo);
        }

        [Test]
        [Category("CardinalDezena")]
        [Description("Teste de cardinal para tratar dezena")]
        public void Test_CardinalDezenaComUnidade_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 51;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Cinquenta e Um";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalDezena")]
        [Description("Teste de cardinal para tratar dezena")]
        public void Test_CardinalDezena_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 15;
            string ret = suporte.GetCardinal(15);
            string expected = "Quinze";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        [Description("Teste de cardinal para tratar centena, dezena")]
        public void Test_CardinalCentenaComUnidade_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 619;
            string ret = suporte.GetCardinal(619);
            string expected = "Seiscentos e Dezenove";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        [Description("Teste de cardinal para tratar centena")]
        public void Test_CardinalCentena_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 600;
            string ret = suporte.GetCardinal(600);
            string expected = "Seiscentos";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        [Description("Teste de cardinal para tratar centena")]
        public void Test_CardinalCem_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 100;
            string ret = suporte.GetCardinal(100);
            string expected = "Cem";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalMilhar")]
        [Description("Teste de cardinal para tratar centena, milhar, unidade")]
        public void Test_CardinalMilharCentenaDezenaUninidade_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 1996;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Mil Novecentos e Noventa e Seis";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        [Description("Teste de cardinal para tratar centena, dezena, unidade")]
        public void Test_CardinalCentenaDezenaUnidade_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 126;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Cento e Vinte e Seis";
            Assert.AreEqual(expected, ret);
        }


        //[Test]
        //[Category("CardinalMilhar")]
        //[Description("Teste de cardinal para tratar centena, dezena, milhar, unidade")]
        //public void Test_CardinalCentenaMilharDezenaUnidade_Sucesso()
        //{
        //    Suporte<Numeral> suporte = new();
        //    suporte.GetDI().Numero = 129996;
        //    string ret = suporte.GetCardinal(suporte.GetDI().Numero);
        //    string expected = "Cento e Vinte e Nove Mil Novecentos e Noventa e Seis";
        //    Assert.AreEqual(expected, ret);
        //}

        [Test]
        [Category("ObjectCreateTest")]
        [Description("Teste de cardinal para tratar milhar")]
        public void Test_ValidadeSuporte_FromJson_Sucesso()
        {
            Suporte<Numeral> suporte = new();


            string json = "{\"Numero\":1000,\"Extenso\":null,\"Erro\":null}";
            Numeral ret = suporte.GetDI().FromJson(json);
            Assert.IsTrue(ret.Numero == 1000);

        }

    }
}