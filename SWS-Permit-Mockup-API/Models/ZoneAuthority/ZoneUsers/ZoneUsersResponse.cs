using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{
    public class ZoneUsersResponse : ResponseBase
    {
        public List<ZoneUserModel> Users { get; set; }
    }
}
