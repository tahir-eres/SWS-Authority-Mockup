using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{
    public class ZoneCompanyActionResponse : ResponseBase
    {
        public ZoneCompanyLite Company { get; set; }
        public string RequestTrackingNumber { get; set; }
    }
}
