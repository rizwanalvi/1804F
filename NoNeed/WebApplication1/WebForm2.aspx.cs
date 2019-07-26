using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod]
        [System.Web.Services.WebMethod]
        public static List<string> GetSearch(string prefixText)
        {
            List<string> al = new List<string>();
            al.Add("Apple");
            al.Add("Ample");
            al.Add("Add in");
            al.Add("Orange");
     

            return al;
        }
    }
}