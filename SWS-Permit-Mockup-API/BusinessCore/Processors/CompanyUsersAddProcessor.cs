using SWS.Mockups.Permit.Api.Models;
using SWS.Mockups.Permit.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SWS.Mockups.Permit.Api.BusinessCore.Processors
{
    public class CompanyUsersAddProcessor : BusinessCore.Base.ProcessorBase
    {
        public CompanyUsersAddProcessor(ConfigurationManager.ConfigurationSettings configurations) : base(configurations) { }

        internal ZoneUserActionResponse Process( string roleName, string tradeLicence, string licenseAuthority, ZoneUserActionRequest user)
        {
            ZoneUserActionResponse response = new ZoneUserActionResponse();
            ZoneCompanyRepoModel company = ZoneAuthorityRepository.Instance.GetZoneCompany(   roleName,  tradeLicence,  licenseAuthority);

            if (company != null)
            {
               var userCheck =  company.Users.Count(u => u.Status.ToLower() == "active" && (u.EmiratesId== user.User.EmiratesId || u.EmailAddress.ToLower()== user.User.EmailAddress.ToLower()));

                if (userCheck == 0)
                {
                    user.User.UserId = company.Users.Count + 10;
                    user.User.Status = "Active";
                    company.Users.Add(user.User);

                    response.User = user.User;
                    response.ResponseMessage = "SUCCESS";
                    response.responseCode = ResponseCode.SUCCESS;
                    response.ValidationErrorsList = new List<NameSet>();
                    response.TimeStamp = DateTime.Now;
                }
                else {
                    response.ResponseMessage = "Emirates Id or Email is already exist.";
                    response.responseCode = ResponseCode.FAILURE;
                    response.ValidationErrorsList = new List<NameSet>() { new NameSet { EnglishName = "Emirates Id or Email is already exist.", ArabicName = "Emirates Id or Email is already exist." } };
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
