using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod]
        [System.Web.Services.WebMethod]
        public static String[] MySearch(string prefixText) {

            String[] _cnt = new string[] { "pakisatn", "Iran","Afganistan" };
            return _cnt;
        }
    }
}