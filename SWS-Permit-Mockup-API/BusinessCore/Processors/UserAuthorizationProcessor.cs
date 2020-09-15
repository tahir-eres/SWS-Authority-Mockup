using SWS.Mockups.Permit.Api.Models;
using SWS.Mockups.Permit.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SWS.Mockups.Permit.Api.BusinessCore.Processors
{
    public class UserAuthorizationProcessor : BusinessCore.Base.ProcessorBase
    {
        public UserAuthorizationProcessor(ConfigurationManager.ConfigurationSettings configurations) : base(configurations) { }

        internal ZoneUserResponse Process( string roleName, string emiratesId)
        {
            ZoneUserResponse response = new ZoneUserResponse();
            ZoneCompanyRepoModel company = ZoneAuthorityRepository.Instance.GetZoneCompany( roleName, emiratesId);

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

                ZoneUserModel user = company.Users.First(u=> u.EmiratesId== emiratesId);
                response.User = new ZoneUserLite
                {
                     BirthDate= user.BirthDate,
                      EmailAddress= user.EmailAddress,
                       EmiratesId= user.EmiratesId,
                        MobileNumber= user.MobileNumber,
                         Name= user.Name,
                          Role= user.Role,
                           Status= user.Status, 
                    UserId= user.UserId, 
                    UserName=user.UserName

                };

                response.ResponseMessage = "SUCCESS";
                response.responseCode = ResponseCode.SUCCESS;
                response.ValidationErrorsList = new List<NameSet>();
                response.TimeStamp = DateTime.Now;

            }
            else
            {
                response.ResponseMessage = "Emiartes Id not found for given role";
                response.responseCode = ResponseCode.FAILURE;
                response.ValidationErrorsList = new List<NameSet>() { new NameSet { EnglishName="Emiartes Id not found", ArabicName= "Emiartes Id not found" } };
                response.TimeStamp = DateTime.Now;
            }

            return response;
        }
    }
}
