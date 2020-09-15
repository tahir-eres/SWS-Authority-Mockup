using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{
    public class ZoneCompanyActionRequest : RequestBase
    {
        public Company Company { get; set; }
        public ZoneUserModel Admin { get; set; }
        public List<ZoneUserModel> Engineers { get; set; }
    }
}
