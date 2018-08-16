using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisenceFile
{
    class AuthorizeFile
    {

        public string Version { get; set; }
        
        public string AuthorizeType { get; set; }

        public string AuthorizeContent { get; set; }


        public DateTime SignDate { get; set; }

        public string ToJson()
        {   
            this.SignDate = DateTime.Now;

            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AuthorizeFile FromJson(string json)
        {   
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AuthorizeFile>(json);
        }
    }
}
