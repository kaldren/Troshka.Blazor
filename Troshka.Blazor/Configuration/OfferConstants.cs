namespace Troshka.Blazor.Configuration
{
    public static class OfferConstants
    {
        public static readonly int CarsMinHorsepower = 1;
        public static readonly int CarsMaxHorsepower = 10000;
        public static readonly int CarsMinMileage = 1;
        public static readonly int CarsMaxMileage = 5000000;
        public static readonly int CarsMinCubics = 1;
        public static readonly int CarsMaxCubics = 10000;
        public static readonly int CarsMinPrice = 0;
        public static readonly int CarsMaxPrice = 20000000;

        public static readonly int MinYear = 1900;
        public static readonly int MaxYear = DateTime.Now.Year;
    }
}
