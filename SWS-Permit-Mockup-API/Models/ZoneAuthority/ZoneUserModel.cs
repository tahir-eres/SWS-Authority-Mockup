using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{
    
   
    public class ZoneUserModel : ZoneUserLite
    {
        public DateTime EmiratesIdExpiresOn { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string PostOfficeBox { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportIssuedOn { get; set; }
        public DateTime PassportExpiresOn { get; set; }
        public string PassportCountry { get; set; }
    }


}
