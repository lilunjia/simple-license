using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisenceFile
{
    class AuthorizeManager
    {
        private AuthorizeManager()
        { }

        private static AuthorizeManager _instance = null;

        public static AuthorizeManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AuthorizeManager();

                return _instance;
            }
        }

        public AuthorizeItem[] LoadItems()
        {   

            return new AuthorizeItem[] { 

                new AuthorizeItem { Text = "机器识别码",Memo = "多个机器识别码可采用换行符或逗号(,)进行分隔" }                
            };
        }



    }
    class AuthorizeItem
    {
        public string Text { get; set; }

        public string Memo { get; set; }

        public override string ToString()
        {   
            return this.Text;
        }
    }



}
