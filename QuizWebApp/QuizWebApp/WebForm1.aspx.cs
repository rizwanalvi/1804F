using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace QuizWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection _sqlConn = null;
        SqlCommand _cmd = null;
       static int _Counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
                _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=QuestionBank;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM  Questions WHERE QID=@id", _sqlConn);
                _Counter++;
            _cmd.Parameters.AddWithValue("@id", _Counter);
            SqlDataReader dReader = _cmd.ExecuteReader();
            dReader.Read();
            Label1.Text = dReader["Question"].ToString();
              //  RadioButton1.Text = dReader["OptionA"].ToString();
                RadioButtonList1.Items[0].Text = dReader["OptionA"].ToString();
                RadioButtonList1.Items[1].Text = dReader["OptionB"].ToString();

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=QuestionBank;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (_sqlConn.State == System.Data.ConnectionState.Closed)
                _sqlConn.Open();
            _Counter++;
            SqlCommand _cmd = new SqlCommand("SELECT * FROM  Questions WHERE QID=@id", _sqlConn);
            _cmd.Parameters.AddWithValue("@id",_Counter);
              SqlDataReader dReader =  _cmd.ExecuteReader();
            dReader.Read();
            Label1.Text = dReader["Question"].ToString();
            //RadioButton1.Text = dReader["OptionA"].ToString();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=QuestionBank;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (_sqlConn.State == System.Data.ConnectionState.Closed)
                _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM  Questions WHERE QID=@id", _sqlConn);
            _Counter--;
            _cmd.Parameters.AddWithValue("@id", _Counter);
            SqlDataReader dReader = _cmd.ExecuteReader();
            dReader.Read();
            Label1.Text = dReader["Question"].ToString();
          //  RadioButton1.Text = dReader["OptionA"].ToString();


        }
    }
}