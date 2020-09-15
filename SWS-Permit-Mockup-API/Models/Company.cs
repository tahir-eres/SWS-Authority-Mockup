using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{
    public class Company : ZoneCompanyLite
    {
        public string PostOfficeBox { get; set; }
        public string PreQualificationStatus { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string OfficeAddress { get; set; }
        public string DedRemarks { get; set; }
        public string DedActivityCode { get; set; }
        public string PreQualificationRemarks { get; set; }
        public NameSet ContactPersonName { get; set; }

    }
}
