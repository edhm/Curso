using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    //http://local:5000/[controller]
    //http://local:5000/WeatherForecast
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetJava(){
            string[] nombresJava=new[]{"JAVA OCA","JAVA OCP", "JAVA SOA","JAVA MICROSERVICES","JAVA ARCHITECT"};
            return nombresJava;
        }
    }
}
