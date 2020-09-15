namespace SWS.Mockups.Permit.Api.Controllers
{
  
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using SWS.Mockups.Permit.Api.ConfigurationManager;

    public class ApiControllerBase : ControllerBase
    {
        protected readonly IOptions<ConfigurationSettings> Configurations;
        public ApiControllerBase(IOptions<ConfigurationSettings> settings)
        {
            Configurations = settings;
        }
    }
}
