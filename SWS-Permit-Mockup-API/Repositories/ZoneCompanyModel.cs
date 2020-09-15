using SWS.Mockups.Permit.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Repositories
{
    public class ZoneCompanyRepoModel
    {
        public Company Company { get; set; }
        public List<ZoneUserModel> Users { get; set; }
        public List<ZoneUserModel> Engineers { get; set; }

    }

}
