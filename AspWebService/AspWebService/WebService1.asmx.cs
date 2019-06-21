using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace AspWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection _sqlconn = null;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int Addition(int a, int b) {

            return a + b;
        }
        [WebMethod]
        public int InsertData(String name,String country) {
            int _flag = 0;
            _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO CUSTOMERS VALUES(@NAME,@CNAME)", _sqlconn);
            _cmd.Parameters.AddWithValue("@NAME", name);
            _cmd.Parameters.AddWithValue("@CNAME", country);
           _flag = (int) _cmd.ExecuteNonQuery();
            return _flag;
        }
        DataSet _ds = null;
        [WebMethod]
        public DataSet SelectAll() {
            _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
             _ds = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM CUSTOMERS", _sqlconn);
            dAdapter.Fill(_ds);
            return _ds;
        }
        [WebMethod]
        public SqlDataReader SelectAll1()
        {
            _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM CUSTOMERS", _sqlconn);


            return _cmd.ExecuteReader();
        }
        [WebMethod]
        public DataSet SelectById(int id)
        {
            _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _ds = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM CUSTOMERS Where CustomerId = @ID ", _sqlconn);
            dAdapter.SelectCommand.Parameters.AddWithValue("@ID", id);
            dAdapter.Fill(_ds);
            return _ds;
        }
    }
}
