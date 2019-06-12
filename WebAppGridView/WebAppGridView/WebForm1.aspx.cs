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
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) {
                LoadGridview();
            }
        }

        public void LoadGridview() {

            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if(_sqlconn.State ==System.Data.ConnectionState.Closed)
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM CUSTOMERS", _sqlconn);
            GridView1.DataSource = _cmd.ExecuteReader();
            GridView1.DataBind();
        }

        protected void OnRowEdit(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGridview();
        }

        protected void OnCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadGridview();
        }

        protected void OnUpdate(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}