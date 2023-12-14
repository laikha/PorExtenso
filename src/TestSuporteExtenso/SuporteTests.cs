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
        public void Test_ValidadeSuporteToJson_NotNull_Sucesso()
        {
            Suporte<Numeral> suporte = new();

            suporte.GetDI().Numero = 1000;
            string ret = suporte.GetDI().ToJson();
            Assert.That(ret, Is.Not.Empty);

        }

        [Test]
        [Category("ObjectCreateTest")]
        [Description("Teste de cardinal para tratar milhar")]
        public void Test_ValidadeSuporteFromJson_NotNull_Sucesso()
        {
            string snd = "{\"Numero\":1000,\"Extenso\":null,\"Erro\":null}";
            Suporte<Numeral> suporte = new();

            Numeral numeral = suporte.GetDI().FromJson(snd);
            
            Assert.That(numeral, Is.Not.Null);  
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
            Assert.That(ret, Is.EqualTo(expected));
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
            Assert.That(ret, Is.EqualTo(expected));
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
            Assert.That(ret, Is.EqualTo(expected));
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
            Assert.That(ret, Is.EqualTo(expected));
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
            Assert.That(ret, Is.EqualTo(expected));
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
            Assert.That(ret, Is.EqualTo(expected));
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
            Assert.That(ret, Is.EqualTo(expected));
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
            Assert.That(ret, Is.EqualTo(expected));
        }


        [Test]
        [Category("CardinalMilhar")]
        [Description("Teste de cardinal para tratar centena, dezena, milhar, unidade")]
        public void Test_CardinalCentenaMilharDezenaUnidade_Sucesso()
        {
            Suporte<Numeral> suporte = new();
            suporte.GetDI().Numero = 129996;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Cento e Vinte e Nove Mil Novecentos e Noventa e Seis";
            Assert.That(ret, Is.EqualTo(expected));
        }

    }
}