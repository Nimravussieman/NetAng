using IdentityModel;

using IdentityServer4.Extensions;
using IdentityServer4.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using NetAng.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetAng.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _claimsFactory;
        private ProfileDataRequestContext profileDatacontext;
        
        public WeatherForecastController(/*ProfileDataRequestContext profileDatacontext,*/UserManager<ApplicationUser> userManager,  IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory,ILogger<WeatherForecastController> logger)
        {
            _userManager = userManager;
            _claimsFactory = claimsFactory;
            //this.profileDatacontext = profileDatacontext;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get(/*, IsActiveContext isActivecontext*/)//string returnUrl = null)
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            // var user = await _userManager.GetUserAsync(User);
            var userName = await _userManager.GetUserAsync(User);// var user = await _userManager.GetUserAsync(User);
            var currentUserId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByIdAsync(currentUserId);

            
            //var sub = profileDatacontext.Subject.GetSubjectId();
            //var user = await _userManager.FindByIdAsync(sub);
            //var principal = await _claimsFactory.CreateAsync(user);

            //var claims = principal.Claims.ToList();
            //claims = claims.Where(claim => profileDatacontext.RequestedClaimTypes.Contains(claim.Type)).ToList();
            //claims.Add(new Claim(JwtClaimTypes.GivenName, user.UserName));

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
