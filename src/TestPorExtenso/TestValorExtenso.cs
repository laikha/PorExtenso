using ExtensoSuporte;
using ExtensoSuporte.Model;
using NUnit.Framework;

namespace Tests
{
    public class TestValorExtenso
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [Category("ObjectCreateTest")]
        public void Test_ValidadeSuporteNotNull()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();

            suporte.GetDI().Numero = 1000;
            string ret = suporte.GetDI().ToJson();
            Assert.IsNotEmpty(ret);

        }

        [Test]
        [Category("Cardinal")]
        public void Test_UnidadeCardinal()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 6;
            var ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Seis";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalDezena")]
        public void Test_CardinalDezenaComUnidade()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 51;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Cinquenta e Um";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalDezena")]
        public void Test_CardinalDezena()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 15;
            string ret = suporte.GetCardinal(15);
            string expected = "Quinze";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        public void Test_CardinalCentenaComUnidade()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 619;
            string ret = suporte.GetCardinal(619);
            string expected = "Seiscentos e Dezenove";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        public void Test_CardinalCentena()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 600;
            string ret = suporte.GetCardinal(600);
            string expected = "Seiscentos";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        public void Test_CardinalCem()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 100;
            string ret = suporte.GetCardinal(100);
            string expected = "Cem";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalMilhar")]
        public void Test_CardinalMilharCentenaDezenaUninidade()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 1996;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Mil Novecentos e Noventa e Seis";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        [Category("CardinalCentena")]
        public void Test_CardinalCentenaDezenaUnidade()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 126;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Cento e Vinte e Seis";
            Assert.AreEqual(expected, ret);
        }


        [Test]
        [Category("CardinalMilhar")]
        public void Test_CardinalCentenaMilharDezenaUnidade()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().Numero = 129996;
            string ret = suporte.GetCardinal(suporte.GetDI().Numero);
            string expected = "Cento e Vinte e Nove Mil Novecentos e Noventa e Seis";
            Assert.AreEqual(expected, ret);
        }

    }
}