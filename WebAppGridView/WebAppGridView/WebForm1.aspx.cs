using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebAppGridView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlConnection _sqlconn = null;
        private SqlCommand _cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                if (_sqlconn.State == System.Data.ConnectionState.Closed)
                    _sqlconn.Open();
                _cmd = new SqlCommand("SELECT * FROM Customers", _sqlconn);
                GridView1.DataSource = _cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}