using SWS.Mockups.Permit.Api.Models;
using SWS.Mockups.Permit.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SWS.Mockups.Permit.Api.BusinessCore.Processors
{
    public class CompanyRegisterProcessor : BusinessCore.Base.ProcessorBase
    {
        public CompanyRegisterProcessor(ConfigurationManager.ConfigurationSettings configurations) : base(configurations) { }

        internal ZoneCompanyActionResponse Process( string roleName, ZoneCompanyActionRequest company)
        { 
            ZoneCompanyActionResponse response = new ZoneCompanyActionResponse();
            ZoneCompanyRepoModel companyCheck = ZoneAuthorityRepository.Instance.GetZoneCompany(   roleName, company.Company.LicenceNumber, company.Company.LicenceAuthority);

            if (companyCheck == null)
            {
                company.Company.Status = "Active";
                company.Admin.Status = "Active";
                company.Admin.UserId = 1;


               var companyModel=   ZoneAuthorityRepository.Instance.CreateZoneCompany(  company.Company, company.Admin);


                response.Company = new ZoneCompanyLite
                {
                    EmailAddress = companyModel.Company.EmailAddress,
                    LicenceAuthority = companyModel.Company.LicenceAuthority,
                    LicenceExpiry = companyModel.Company.LicenceExpiry,
                    LicenceIssuedOn = companyModel.Company.LicenceIssuedOn,
                    LicenceNumber = companyModel.Company.LicenceNumber,
                    Name = companyModel.Company.Name,
                    PhoneNumber = companyModel.Company.PhoneNumber,
                    Role = companyModel.Company.Role,
                    Status = companyModel.Company.Status
                };

                response.RequestTrackingNumber = string.Format("{1}-{0}",  company.Company.LicenceNumber, roleName);

                    response.ResponseMessage = "SUCCESS";
                    response.responseCode = ResponseCode.SUCCESS;
                    response.ValidationErrorsList = new List<NameSet>();
                    response.TimeStamp = DateTime.Now;
               

            }
            else
            {
                response.ResponseMessage = "Trade license is already exist.";
                response.responseCode = ResponseCode.FAILURE;
                response.ValidationErrorsList = new List<NameSet>() { new NameSet { EnglishName = "Trade license is already exist.", ArabicName = "Trade license is already exist." } };
                response.TimeStamp = DateTime.Now;
            }

            return response;
        }
    }
}
