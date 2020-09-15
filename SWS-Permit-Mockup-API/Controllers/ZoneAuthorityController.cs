namespace WebApplication1.Controllers
{
    using SWS.Mockups.Permit.Api.Controllers;


    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using SWS.Mockups.Permit.Api.Models;
    using SWS.Mockups.Permit.Api.BusinessCore.Processors;
    using SWS.Mockups.Permit.Api.ConfigurationManager;
    using System.Collections.Generic;
    using SWS.Mockups.Permit.Api.Repositories;

    [ApiController]
    public class ZoneAuthorityController : ApiControllerBase
    {
        public ZoneAuthorityController(IOptions<ConfigurationSettings> settings) : base(settings)
        {
        }

        [HttpGet]
        [Route("v1/zone-authority/echo")]
        public ActionResult Check(string message = "running")
        {
            return Ok(string.Format("{0}-{1}", message, System.DateTime.Now));
        }



        [HttpGet]
        [Route("/v1/users/{roleName}/{emiratesId}")]
        public ZoneUserResponse ProcessUserAuthorizationRequest( string roleName, string emiratesId)
        {
            var response = new UserAuthorizationProcessor(Configurations.Value).Process( roleName, emiratesId);
            return response;


        }


        [HttpGet]
        [Route("/v1/companies/{licenseAuthority}/{tradeLicence}/{roleName}")]
        public ZoneCompanyResponse ProcessCompanyrAuthorizationRequest( string roleName, string tradeLicence, string licenseAuthority)
        {
            var response = new CompanyAuthorizationProcessor(Configurations.Value).Process( roleName, tradeLicence, licenseAuthority);
            return response;


        }

        [HttpGet]
        [Route("/v1/users/{licenseAuthority}/{tradeLicence}/{roleName}")]
        public ZoneUsersResponse ProcessGetCompanyUsersRequest(string roleName, string tradeLicence, string licenseAuthority)
        {
            var response = new CompanyUsersListProcessor(Configurations.Value).Process( roleName, tradeLicence, licenseAuthority);
            return response;
        }

        [HttpPost]
        [Route("/v1/users/{licenseAuthority}/{tradeLicence}/{roleName}")]
        public ZoneUserActionResponse ProcessCompanyUsersAddRequest(string roleName, string tradeLicence, string licenseAuthority,  [FromBody]ZoneUserActionRequest user)
        {
            var response = new CompanyUsersAddProcessor(Configurations.Value).Process( roleName, tradeLicence, licenseAuthority,  user);
            return response;
        }

        [HttpPost]
        [HttpPut]
        [Route("/v1/users/{licenseAuthority}/{tradeLicence}/{roleName}/{emiratesId}")]
        public ZoneUserActionResponse ProcessCompanyUsersUpdateRequest( string roleName, string tradeLicence, string licenseAuthority, string emiratesId, [FromBody]ZoneUserActionRequest user)
        {
            var response = new CompanyUsersUpdateProcessor(Configurations.Value).Process( roleName, tradeLicence, licenseAuthority, emiratesId, user);
            return response;
        }


        [HttpDelete]
        [Route("/v1/users/{licenseAuthority}/{tradeLicence}/{roleName}/{emiratesId}")]
        public ZoneUserActionResponse ProcessCompanyUsersDeleteRequest( string roleName, string tradeLicence, string licenseAuthority, string emiratesId)
        {
            var response = new CompanyUsersDeleteProcessor(Configurations.Value).Process( roleName, tradeLicence, licenseAuthority, emiratesId);
            return response;
        }

        [HttpPost]
        [Route("v1/companies/{roleName}")]
        public ZoneCompanyActionResponse ProcessCompanyUsersDeleteRequest( string roleName, [FromBody]ZoneCompanyActionRequest company)
        {
            var response = new CompanyRegisterProcessor(Configurations.Value).Process( roleName, company);
            return response;
        }



    }
}
