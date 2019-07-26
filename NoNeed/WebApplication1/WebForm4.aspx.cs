using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod]
        [System.Web.Services.WebMethod]
        public static String[] SearchData(string prefixText)
        {
            String[] al = new String[] { "Apple" ,"Ample", "Add in" , "Orange" };
                  return al;
        }
    }
}