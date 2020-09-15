using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{
    public class ZoneUserLite
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public NameSet Name { get; set; }
        public string EmiratesId { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
    }

}
