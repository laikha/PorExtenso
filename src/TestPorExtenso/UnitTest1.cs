using ExtensoSuporte;
using ExtensoSuporte.Model;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void A_ValidaSuporte()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();

            suporte.GetDI().numero = 1000;
            string ret = suporte.GetDI().ToJson();
            Assert.IsNotEmpty(ret);

        }

        [Test]
        public void B_ValidaCardinalUnidade()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 6;
            var ret = suporte.GetCardinal(suporte.GetDI().numero);
            string expected = "Seis";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void B_ValidaCardinalDezena()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 51;
            string ret = suporte.GetCardinal(suporte.GetDI().numero);
            string expected = "Cinquenta e Um";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void B_ValidaCardinalDezena2()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 15;
            string ret = suporte.GetCardinal(15);
            string expected = "Quinze";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void B_ValidaCardinalCentena()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 619;
            string ret = suporte.GetCardinal(619);
            string expected = "Seiscentos e Dezenove";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void B_ValidaCardinalMilhar()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 1996;
            string ret = suporte.GetCardinal(suporte.GetDI().numero);
            string expected = "Mil Novecentos e Noventa e Seis";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void C_ValidaCentenaAglutinada()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 126;
            string ret = suporte.GetCardinal(suporte.GetDI().numero);
            string expected = "Cento e Vinte e Seis";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void B_ValidaCardinalMilhar2()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 2996;
            string ret = suporte.GetCardinal(suporte.GetDI().numero);
            string expected = "Dois Mil Novecentos e Noventa e Seis";
            Assert.AreEqual(expected, ret);
        }

        [Test]
        public void B_ValidaCardinalMilhar3()
        {
            Suporte<Numeral> suporte = new Suporte<Numeral>();
            suporte.GetDI().numero = 129996;
            string ret = suporte.GetCardinal(suporte.GetDI().numero);
            string expected = "Cento e Vinte e Nove Mil Novecentos e Noventa e Seis";
            Assert.AreEqual(expected, ret);
        }
    }
}