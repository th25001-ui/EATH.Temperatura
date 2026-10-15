using Microsoft.VisualStudio.TestTools.UnitTesting;
using EATH.Temperatura;

namespace EATH.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class ConvertidorTemperaturaTests
    {
        private ConvertidorTemperatura convertidor = new();

        [TestMethod]
        public void CelsiusAFahrenheit_DebeConvertirCorrectamente()
        {
            double resultado = convertidor.CelsiusAFahrenheit(0);
            Assert.AreEqual(32.0, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitACelsius_DebeConvertirCorrectamente()
        {
            double resultado = convertidor.FahrenheitACelsius(32);
            Assert.AreEqual(0.0, resultado, 0.001);
        }

        [TestMethod]
        public void CelsiusAKelvin_DebeConvertirCorrectamente()
        {
            double resultado = convertidor.CelsiusAKelvin(0);
            Assert.AreEqual(273.15, resultado, 0.001);
        }
    }
}