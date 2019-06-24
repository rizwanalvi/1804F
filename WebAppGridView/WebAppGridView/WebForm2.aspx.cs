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
                SqlConnection _sqconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand _cmd = new SqlCommand("SELECT * FROM CUSTOMERS", _sqconn);
                if (_sqconn.State == System.Data.ConnectionState.Closed)
                    _sqconn.Open();
                Repeater1.DataSource = _cmd.ExecuteReader();
                Repeater1.DataBind();
            }
        }
    }
}