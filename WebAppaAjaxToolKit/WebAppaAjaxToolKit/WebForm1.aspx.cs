using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppaAjaxToolKit
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod]
        [System.Web.Services.WebMethod]
        public List<String> GetSearch(String prefixStr ) {
            List<String> al = new List<string>();
            al.Add("Apple");
            al.Add("Ample");
            al.Add("Auth");
            al.Add("Orange");
            return al;
        }
    }
}