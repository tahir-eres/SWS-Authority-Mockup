using SWS.Mockups.Permit.Api.Models;
using SWS.Mockups.Permit.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SWS.Mockups.Permit.Api.BusinessCore.Processors
{
    public class CompanyUsersDeleteProcessor : BusinessCore.Base.ProcessorBase
    {
        public CompanyUsersDeleteProcessor(ConfigurationManager.ConfigurationSettings configurations) : base(configurations) { }

        internal ZoneUserActionResponse Process( string roleName, string tradeLicence, string licenseAuthority,string emiratesId )
        {
            ZoneUserActionResponse response = new ZoneUserActionResponse();
            ZoneCompanyRepoModel company = ZoneAuthorityRepository.Instance.GetZoneCompany(   roleName,  tradeLicence,  licenseAuthority);

            if (company != null)
            {
               var userCheck =  company.Users.Where(u => u.Status.ToLower() == "active" && (u.EmiratesId== emiratesId ) && u.Role.ToLower() !="admin").ToList();

                if (userCheck.Count == 1)
                {
                    var subject = userCheck.First();
                  
                    subject.Status ="Delete";

                    response.User = subject;
                    response.ResponseMessage = "SUCCESS";
                    response.responseCode = ResponseCode.SUCCESS;
                    response.ValidationErrorsList = new List<NameSet>();
                    response.TimeStamp = DateTime.Now;
                }
                else {
                    response.ResponseMessage = "Emirates Id is not exist.";
                    response.responseCode = ResponseCode.FAILURE;
                    response.ValidationErrorsList = new List<NameSet>() { new NameSet { EnglishName = "Emirates Id is not exist.", ArabicName = "Emirates Id is not exist." } };
                    response.TimeStamp = DateTime.Now;
                }

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
