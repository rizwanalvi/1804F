using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace QuizWebApp
{
    public partial class ImgView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            byte[] img = FileUpload1.FileBytes;
            SqlConnection _sqlc = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlc.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO CUSINFO VALUES(@NAME,@IMG)",_sqlc);
            _cmd.Parameters.AddWithValue("@NAME", FileUpload1.FileName);
            _cmd.Parameters.AddWithValue("@IMG",img);
            _cmd.ExecuteNonQuery();
           
        }

        public String GetImage(Object obj) {
            byte[] img =(byte[])   obj;
            return "data:image/jpeg;base64," + Convert.ToBase64String(img);
        }
    }
}