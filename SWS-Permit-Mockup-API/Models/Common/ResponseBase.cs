using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWS.Mockups.Permit.Api.Models
{

   
    public abstract class ResponseBase
    {
        protected ResponseBase()
        {

        }

        public ResponseCode responseCode { get; set; }
        public string ResponseMessage { get; set; }
        public DateTime TimeStamp { get; set; }
        
        public List<NameSet> ValidationErrorsList { get; set; }
    }

    public class VoidResponse : ResponseBase
    {
    }

   
}
