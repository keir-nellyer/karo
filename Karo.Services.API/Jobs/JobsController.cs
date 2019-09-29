using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Karo.Services.API.Jobs
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            var airts = new Job()
            {
                Company = "Airts",
                Position = "Software Developer",
                Start = new DateTimeOffset(2017, 4, 1, 0, 0, 0, TimeSpan.Zero),
                Description =
                    "A software development company focused on A.I. powered planning and scheduling for professional services. My focus is mainly on backend services which are predominantly written in C# on .NET Core/Framework where I design/implement new features and solutions to further our product, Braid."
            };

            var cubeCraft = new Job()
            {
                Company = "CubeCraft Games",
                Position = "Service Developer",
                Start = new DateTimeOffset(2016, 12, 1, 0, 0, 0, TimeSpan.Zero),
                Description = "Developed game server features and backend APIs, systems and storage schemas for a remote software development company."
            };
            
            return new List<Job>() { airts, cubeCraft };
        }
    }
}