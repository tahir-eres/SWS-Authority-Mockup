using SWS.Mockups.Permit.Api.Models;
using SWS.Mockups.Permit.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SWS.Mockups.Permit.Api.BusinessCore.Processors
{
    public class CompanyUsersUpdateProcessor : BusinessCore.Base.ProcessorBase
    {
        public CompanyUsersUpdateProcessor(ConfigurationManager.ConfigurationSettings configurations) : base(configurations) { }

        internal ZoneUserActionResponse Process( string roleName, string tradeLicence, string licenseAuthority,string emiratesId ,ZoneUserActionRequest user)
        {
            ZoneUserActionResponse response = new ZoneUserActionResponse();
            ZoneCompanyRepoModel company = ZoneAuthorityRepository.Instance.GetZoneCompany(   roleName,  tradeLicence,  licenseAuthority);

            if (company != null)
            {
               var userCheck =  company.Users.Where(u => u.Status.ToLower() == "active" && (u.EmiratesId== user.User.EmiratesId)).ToList();

                if (userCheck.Count == 1)
                {
                    var subject = userCheck.First();

                    subject.BirthDate = user.User.BirthDate;
                    subject.Designation = user.User.Designation;
                    subject.EmailAddress = user.User.EmailAddress;
                    subject.EmiratesIdExpiresOn = user.User.EmiratesIdExpiresOn;
                    subject.Gender = user.User.Gender;
                    subject.MobileNumber = user.User.MobileNumber;
                    subject.Name = user.User.Name;
                    subject.Nationality = user.User.Nationality;
                    
                    subject.PassportCountry = user.User.PassportCountry;
                    subject.PassportExpiresOn = user.User.PassportExpiresOn;
                    subject.PassportIssuedOn = user.User.PassportIssuedOn;

                    subject.PassportNumber = user.User.PassportNumber;
                    subject.PostOfficeBox = user.User.PostOfficeBox;
                    subject.Role = user.User.Role;
                    subject.Status = string.IsNullOrEmpty( user.User.Status) ? subject.Status: user.User.Status;

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
