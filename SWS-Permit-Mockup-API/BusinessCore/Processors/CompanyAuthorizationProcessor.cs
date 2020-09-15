using SWS.Mockups.Permit.Api.Models;
using SWS.Mockups.Permit.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SWS.Mockups.Permit.Api.BusinessCore.Processors
{
    public class CompanyAuthorizationProcessor : BusinessCore.Base.ProcessorBase
    {
        public CompanyAuthorizationProcessor(ConfigurationManager.ConfigurationSettings configurations) : base(configurations) { }

        internal ZoneCompanyResponse Process( string roleName, string tradeLicence, string licenseAuthority)
        {
            ZoneCompanyResponse response = new ZoneCompanyResponse();
            ZoneCompanyRepoModel company = ZoneAuthorityRepository.Instance.GetZoneCompany(   roleName,  tradeLicence,  licenseAuthority);

            if (company != null)
            {
                response.Company = new ZoneCompanyLite
                {
                    EmailAddress = company.Company.EmailAddress,
                    LicenceAuthority = company.Company.LicenceAuthority,
                    LicenceExpiry = company.Company.LicenceExpiry,
                    LicenceIssuedOn = company.Company.LicenceIssuedOn,
                    LicenceNumber = company.Company.LicenceNumber,
                    Name = company.Company.Name,
                    PhoneNumber = company.Company.PhoneNumber,
                    Role = company.Company.Role,
                    Status = company.Company.Status
                };

                response.ResponseMessage = "SUCCESS";
                response.responseCode = ResponseCode.SUCCESS;
                response.ValidationErrorsList = new List<NameSet>();
                response.TimeStamp = DateTime.Now;

            }
            else
            {
                response.ResponseMessage = "Trade License not found for given role";
                response.responseCode = ResponseCode.FAILURE;
                response.ValidationErrorsList = new List<NameSet>() { new NameSet { EnglishName= "Trade License not found", ArabicName= "Trade License not found" } };
                response.TimeStamp = DateTime.Now;
            }

            return response;
        }
    }
}
