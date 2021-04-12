using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Web.Common
{
    [Serializable]
    public class UserSession
    {
        public string UserName { set; get; }
        public string AccountID { set; get; }
    }
}