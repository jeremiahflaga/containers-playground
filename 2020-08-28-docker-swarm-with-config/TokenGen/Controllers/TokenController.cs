using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace TokenGen.Controllers
{
    namespace TokenGen.Controllers
    {
        [Route("api/[controller]")]
        public class TokenController : Controller
        {
            private readonly IOptionsMonitor<SampleSettings> sampleSettings;

            // ref "Configuration should use the options pattern." - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1
            // ref "Options pattern in ASP.NET Core" - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-3.1#ioptionsmonitor
            public TokenController(IOptionsMonitor<SampleSettings> sampleSettings)
            {
                this.sampleSettings = sampleSettings;
            }

            [HttpGet]
            public dynamic Get()
            {
                return new
                {
                    Guid = Guid.NewGuid().ToString(),
                    Expires = DateTime.UtcNow.AddHours(1),
                    Issuer = Environment.MachineName,
                    Setting1 = sampleSettings.CurrentValue.Setting1,
                    Setting2 = sampleSettings.CurrentValue.Setting2,
                };
            }
        }
    }
}
