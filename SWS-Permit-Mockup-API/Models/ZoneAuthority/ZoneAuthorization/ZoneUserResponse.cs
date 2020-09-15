using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models

{
    public class ZoneUserResponse : ResponseBase
    {
        public ZoneUserLite User { get; set; }
        public ZoneCompanyLite Company { get; set; }
    }

}
