using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{
    public class ZoneCompanyLite
    {
        public NameSet Name { get; set; }
        public string Role { get; set; }
        public string LicenceNumber { get; set; }
        public string LicenceAuthority { get; set; }
        public DateTime LicenceExpiry { get; set; }
        public DateTime LicenceIssuedOn { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Status { get; set; }

    }
}
