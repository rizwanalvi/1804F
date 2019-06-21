using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebAppGridView
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection _sqconn = new SqlConnection(@"");
                SqlCommand _cmd = new SqlCommand("", _sqconn);
                if (_sqconn.State == System.Data.ConnectionState.Closed)
                    _sqconn.Open();
                Repeater1.DataSource = _cmd.ExecuteReader();
                Repeater1.DataBind();
            }
        }
    }
}