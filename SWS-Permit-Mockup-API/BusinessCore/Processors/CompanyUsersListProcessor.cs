using SWS.Mockups.Permit.Api.Models;
using SWS.Mockups.Permit.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SWS.Mockups.Permit.Api.BusinessCore.Processors
{
    public class CompanyUsersListProcessor : BusinessCore.Base.ProcessorBase
    {
        public CompanyUsersListProcessor(ConfigurationManager.ConfigurationSettings configurations) : base(configurations) { }

        internal ZoneUsersResponse Process( string roleName, string tradeLicence, string licenseAuthority)
        {
            ZoneUsersResponse response = new ZoneUsersResponse();
            ZoneCompanyRepoModel company = ZoneAuthorityRepository.Instance.GetZoneCompany(   roleName,  tradeLicence,  licenseAuthority);

            if (company != null)
            {
                response.Users = company.Users.Where(u => u.Status.ToLower() == "active").ToList();

                response.ResponseMessage = "SUCCESS";
                response.responseCode = ResponseCode.SUCCESS;
                response.ValidationErrorsList = new List<NameSet>();
                response.TimeStamp = DateTime.Now;

            }
            else
            {
                response.ResponseMessage = "Trade License not found.";
                response.responseCode = ResponseCode.FAILURE;
                response.ValidationErrorsList = new List<NameSet>() { new NameSet { EnglishName= "Trade License not found", ArabicName= "Trade License not found" } };
                response.TimeStamp = DateTime.Now;
            }

            return response;
        }
    }
}
