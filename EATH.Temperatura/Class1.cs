namespace EATH.Temperatura
{
    public class ConvertidorTemperatura
    {
        public double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public double CelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}