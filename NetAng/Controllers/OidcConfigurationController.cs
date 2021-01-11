using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Controllers
{
    [ApiController]
    public class OidcConfigurationController : ControllerBase
    {
        private readonly IClientRequestParametersProvider _clientRequestParametersProvider;
        //static ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        //{
        //    builder.AddConsole();
        //});
        //ILogger logger = loggerFactory.CreateLogger<Startup>();

        public OidcConfigurationController(IClientRequestParametersProvider clientRequestParametersProvider)
        {
            _clientRequestParametersProvider = clientRequestParametersProvider;
        }

        [HttpGet("_configuration/{clientId}")]
        public IActionResult GetClientRequestParameters([FromRoute] string clientId)
        {
            var parameters = _clientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            //logger.LogInformation($"||||||||||||||||||||||||||||||||||: {clientId}");
            return Ok(parameters);
        }
    }
}
