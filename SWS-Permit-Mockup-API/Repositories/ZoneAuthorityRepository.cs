using SWS.Mockups.Permit.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Repositories
{

    public class ZoneAuthorityRepository
    {
        #region Initializer
        public static ZoneAuthorityRepository Instance { get { return _internalInstance; } }
        private static readonly ZoneAuthorityRepository _internalInstance = new ZoneAuthorityRepository();
        private ZoneAuthorityRepository()
        {
            _repoData = new  List<ZoneCompanyRepoModel>();
            InitializeData();
        }

        private void InitializeData()
        {

            _repoData.Add(new ZoneCompanyRepoModel
            {
                Company = new Company
                {
                    ContactPersonName = new NameSet { EnglishName = "Abdul Rehman", ArabicName = "Abdul Rehman Arabic" },
                    Name = new NameSet { EnglishName = "ABC Contractor", ArabicName = "ABC Contractor Arabic" },
                    EmailAddress = "contact@abcdevelopers.com",
                    LicenceAuthority = "DED",
                    LicenceExpiry = DateTime.Now.AddDays(100),
                    LicenceIssuedOn = DateTime.Now.AddDays(-100),
                    LicenceNumber = "ABCCONST",
                    OfficeAddress = "Dubai UAE",
                    PhoneNumber = "044050658",
                    PostOfficeBox = "1245",
                    PreQualificationStatus = "Active",
                     DedActivityCode="00",
                      DedRemarks="",
                       TaxRegistrationNumber="",
                    PreQualificationRemarks = "",
                    Role = "Contractor",
                    Status = "Active"
                    
                },
                Engineers = new List<ZoneUserModel>(),
                Users = new List<ZoneUserModel> {
                   new ZoneUserModel{ UserId=3,EmiratesId="784198419365130", EmailAddress="user1@sws.ae", UserName="user1@sws.ae",Name= new NameSet{  EnglishName="Abdul Rehman", ArabicName="Abdul Rehman" }, BirthDate= DateTime.Now.AddYears(-40), Designation="Engineer", EmiratesIdExpiresOn= DateTime.Now.AddYears(3), Gender="Male", MobileNumber="00971557896523", Nationality="Egypt", PassportCountry="Egypt", PassportExpiresOn=DateTime.Now.AddYears(5), PassportIssuedOn=DateTime.Now.AddYears(-1), PassportNumber="AP45899", PostOfficeBox="1234", Role="Admin", Status="Active"     },
                   new ZoneUserModel{ UserId=4,EmiratesId="784198419365140", EmailAddress="user2@sws.ae", UserName="user2@sws.ae",Name= new NameSet{  EnglishName="Sharib Ahmad", ArabicName="Sharib Ahmad" }, BirthDate= DateTime.Now.AddYears(-40), Designation="Engineer", EmiratesIdExpiresOn= DateTime.Now.AddYears(3), Gender="Male", MobileNumber="00971557896523", Nationality="Egypt", PassportCountry="Egypt", PassportExpiresOn=DateTime.Now.AddYears(5), PassportIssuedOn=DateTime.Now.AddYears(-1), PassportNumber="AP45899", PostOfficeBox="1234", Role="User", Status="Active"     }
                }
            });

            _repoData.Add(new ZoneCompanyRepoModel
            {
                Company = new Company
                {
                    ContactPersonName = new NameSet { EnglishName = "Ejaz Khan", ArabicName = "Ejaz Khan" },
                    Name = new NameSet { EnglishName = "ABC Consultant", ArabicName = "ABC Consultant Arabic" },
                    EmailAddress = "contact@abcdevelopers.com",
                    LicenceAuthority = "DED",
                    LicenceExpiry = DateTime.Now.AddDays(100),
                    LicenceIssuedOn = DateTime.Now.AddDays(-100),
                    LicenceNumber = "ABCCONSL",
                    OfficeAddress = "Dubai UAE",
                    PhoneNumber = "044050658",
                    PostOfficeBox = "1245",
                    PreQualificationStatus = "Active",
                    DedRemarks = "",
                     DedActivityCode="00",
                      TaxRegistrationNumber="",
                       PreQualificationRemarks="",
                    Role = "Consultant",
                    Status = "Active"
                    
                },
                Engineers = new List<ZoneUserModel>(),
                Users = new List<ZoneUserModel> {

                   new ZoneUserModel{ UserId=6,EmiratesId="784198419365160", EmailAddress="user4@sws.ae", UserName="user4@sws.ae",Name= new NameSet{  EnglishName="Ejaz Khan", ArabicName="Ejaz Khan" }, BirthDate= DateTime.Now.AddYears(-40), Designation="Engineer", EmiratesIdExpiresOn= DateTime.Now.AddYears(3), Gender="Male", MobileNumber="00971557896523", Nationality="Egypt", PassportCountry="Egypt", PassportExpiresOn=DateTime.Now.AddYears(5), PassportIssuedOn=DateTime.Now.AddYears(-1), PassportNumber="AP45899", PostOfficeBox="1234", Role="Admin", Status="Active"     },
                   new ZoneUserModel{ UserId=7,EmiratesId="784198419365170", EmailAddress="user5@sws.ae", UserName="user5@sws.ae",Name= new NameSet{  EnglishName="Usman Mudaser", ArabicName="Usman Mudaser" }, BirthDate= DateTime.Now.AddYears(-40), Designation="Engineer", EmiratesIdExpiresOn= DateTime.Now.AddYears(3), Gender="Male", MobileNumber="00971557896523", Nationality="Egypt", PassportCountry="Egypt", PassportExpiresOn=DateTime.Now.AddYears(5), PassportIssuedOn=DateTime.Now.AddYears(-1), PassportNumber="AP45899", PostOfficeBox="1234", Role="User", Status="Active"     }

                }
            });

            _repoData.Add(new ZoneCompanyRepoModel
            {
                Company = new Company
                {
                    ContactPersonName = new NameSet { EnglishName = "Ejaz Ali", ArabicName = "Ejaz Ali" },
                    Name = new NameSet { EnglishName = "XYZ Consultant", ArabicName = "XYZ Consultant Arabic" },
                    EmailAddress = "contact@xyzdevelopers.com",
                    LicenceAuthority = "DED",
                    LicenceExpiry = DateTime.Now.AddDays(100),
                    LicenceIssuedOn = DateTime.Now.AddDays(-100),
                    LicenceNumber = "XYZCONSL",
                    OfficeAddress = "Dubai UAE",
                    PhoneNumber = "044050658",
                    PostOfficeBox = "1245",
                    PreQualificationStatus = "Blocked",
                    DedRemarks = "",
                     DedActivityCode="00",
                      PreQualificationRemarks="",
                    Role = "Consultant",
                    Status = "Active",
                    TaxRegistrationNumber = ""
                },
                Engineers = new List<ZoneUserModel>(),
                Users = new List<ZoneUserModel> {
                   new ZoneUserModel{ UserId=8,EmiratesId="784198419365180", EmailAddress="user6@sws.ae", UserName="user6@sws.ae",Name= new NameSet{  EnglishName="Ejaz Ali", ArabicName="Ejaz Ali" }, BirthDate= DateTime.Now.AddYears(-40), Designation="Engineer", EmiratesIdExpiresOn= DateTime.Now.AddYears(3), Gender="Male", MobileNumber="00971557896523", Nationality="Egypt", PassportCountry="Egypt", PassportExpiresOn=DateTime.Now.AddYears(5), PassportIssuedOn=DateTime.Now.AddYears(-1), PassportNumber="AP45899", PostOfficeBox="1234", Role="Admin", Status="Active"     },
                   new ZoneUserModel{ UserId=9,EmiratesId="784198419365190", EmailAddress="user7@sws.ae", UserName="user7@sws.ae",Name= new NameSet{  EnglishName="Saad Zahid", ArabicName="Saad Zahid" }, BirthDate= DateTime.Now.AddYears(-40), Designation="Engineer", EmiratesIdExpiresOn= DateTime.Now.AddYears(3), Gender="Male", MobileNumber="00971557896523", Nationality="Egypt", PassportCountry="Egypt", PassportExpiresOn=DateTime.Now.AddYears(5), PassportIssuedOn=DateTime.Now.AddYears(-1), PassportNumber="AP45899", PostOfficeBox="1234", Role="User", Status="Active"     }
                }
            });
        }

    
       
        #endregion

        private List<ZoneCompanyRepoModel> _repoData = null;


       


        internal ZoneCompanyRepoModel GetZoneCompany( string roleName, string emiratesId)
        {
           

            var companies = _repoData.Where(p => p.Users.Any(u => u.EmiratesId == emiratesId && u.Status.ToLower() == "active")); ;

            if (companies.Count() == 1 && companies.First().Company.Role.ToLower()== roleName.ToLower())
            {
                return companies.First();
            }
            else {
                return default(ZoneCompanyRepoModel);
            }

        }


        internal ZoneCompanyRepoModel GetZoneCompany(string roleName, string tradeLicence, string licenseAuthority)
        {

            var companies = _repoData.Where(u => u.Company.Status.ToLower() == "active" &&  u.Company.LicenceAuthority.ToLower() == licenseAuthority.ToLower() && u.Company.Role.ToLower() == roleName.ToLower() && u.Company.LicenceNumber.ToLower() == tradeLicence.ToLower());

            if (companies.Count() == 1)
            {
                return companies.First();
            }
            else
            {
                return default(ZoneCompanyRepoModel);
            }

        }

        internal ZoneCompanyRepoModel CreateZoneCompany(Company company, ZoneUserModel admin)
        {

            ZoneCompanyRepoModel companyData = new ZoneCompanyRepoModel { Company = company, Users = new List<ZoneUserModel> { admin }, Engineers = new List<ZoneUserModel>() };
            _repoData.Add(companyData);
            return companyData;

        }

    }
}
