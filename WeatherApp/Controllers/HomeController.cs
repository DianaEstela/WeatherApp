using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            List<CityWeather> cityWeathers = new List<CityWeather>()
            {
              new CityWeather()
              {
                   CityUniqueCode="LDN", CityName="London",
                   DateAndTime=Convert.ToDateTime("2030-01-01 8:00"),
                   TemperatureFahrenheit=33
              },
               new CityWeather()
               {
                    CityUniqueCode="NYC", CityName="London",
                    DateAndTime=Convert.ToDateTime("2030-01-01 3:00"),
                    TemperatureFahrenheit=60

               },
                new CityWeather()
               {
                    CityUniqueCode="PAR", CityName="Paris",
                    DateAndTime=Convert.ToDateTime("2030-01-01 9:00"),
                    TemperatureFahrenheit=82

               }
            };
          
            


            return View(cityWeathers);
        }

        [Route("weather/{cityCode}")]
        public IActionResult Details(string cityCode)
        {
            List<CityWeather> cityWeathers = new List<CityWeather>()
            {
              new CityWeather()
              {
                   CityUniqueCode="LDN", CityName="London",
                   DateAndTime=Convert.ToDateTime("2030-01-01 8:00"),
                   TemperatureFahrenheit=33
              },
               new CityWeather()
               {
                    CityUniqueCode="NYC", CityName="London",
                    DateAndTime=Convert.ToDateTime("2030-01-01 3:00"),
                    TemperatureFahrenheit=60

               },
                new CityWeather()
               {
                    CityUniqueCode="PAR", CityName="Paris",
                    DateAndTime=Convert.ToDateTime("2030-01-01 9:00"),
                    TemperatureFahrenheit=82

               }
            };
             CityWeather? filter = cityWeathers.Where(x => x.CityUniqueCode.Equals(cityCode)).FirstOrDefault();



            return View(filter);
        }
    }
}
