using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace WebAppGridView
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                String s = ConfigurationManager.ConnectionStrings["StrConn"].ConnectionString;
                SqlConnection coon = new SqlConnection(s);
                if (coon.State == System.Data.ConnectionState.Closed)
                {
                coon.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMERS", coon);
               Repeater1.DataSource = cmd.ExecuteReader();
                Repeater1.DataBind();
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           // LinkButton btnEdit = (LinkButton) sender ;
            LinkButton btnEdit = sender as LinkButton;
           RepeaterItem item =  btnEdit.Parent as RepeaterItem;
            TextBox txtName  = item.FindControl("TextBox1") as TextBox;
            Label lblName = item.FindControl("Label2") as Label;
            Button btnCancel = item.FindControl("Button1") as Button;
            txtName.Visible = true;
            lblName.Visible = false;
            btnCancel.Visible = true;
            btnEdit.Visible = false;
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btnEdit = sender as Button;
            RepeaterItem item = btnEdit.Parent as RepeaterItem;
            TextBox txtName = item.FindControl("TextBox1") as TextBox;
            Label lblName = item.FindControl("Label2") as Label;
            Button btnCancel = item.FindControl("Button1") as Button;
            btnCancel.Visible = false;
            txtName.Visible = false;
            lblName.Visible = true;
            

        }
    }
}