using Xunit;
using EATH.Temperatura;

namespace EATH.Temperatura.UnitTestxUnit
{
    public class ConvertidorTemperaturaTests
    {
        private readonly ConvertidorTemperatura convertidor = new();

        [Fact]
        public void CelsiusAFahrenheit_DebeConvertirCorrectamente()
        {
            double resultado = convertidor.CelsiusAFahrenheit(0);
            Assert.Equal(32.0, resultado, 3);
        }

        [Fact]
        public void FahrenheitACelsius_DebeConvertirCorrectamente()
        {
            double resultado = convertidor.FahrenheitACelsius(32);
            Assert.Equal(0.0, resultado, 3);
        }

        [Fact]
        public void CelsiusAKelvin_DebeConvertirCorrectamente()
        {
            double resultado = convertidor.CelsiusAKelvin(0);
            Assert.Equal(273.15, resultado, 3);
        }
    }
}