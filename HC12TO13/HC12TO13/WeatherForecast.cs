namespace HC12TO13
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {
            
        }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        [Obsolete("Use Title")]
        public string? Summary { get; set; }

        public string? Title { get; set; }
    }
}