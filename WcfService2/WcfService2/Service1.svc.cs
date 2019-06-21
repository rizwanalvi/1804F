using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection _sqlconn = null;
        public int InsertData(string sName, string CName)
        {
            _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if(_sqlconn.State ==System.Data.ConnectionState.Closed)
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO CUSTOMERS VALUES(@NAME,@CNAME)",_sqlconn);
            _cmd.Parameters.AddWithValue("@NAME",sName);
            _cmd.Parameters.AddWithValue("@CNAME", CName);
            int _flag= int.Parse(_cmd.ExecuteNonQuery().ToString());
            return _flag;
        }

        public SqlDataReader SelectAll()
        {
            return null;
        }

        public int UpdateData(int id, string sName, string CName)
        {
            _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=CUSTOMERINFO;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("UPDATE CUSTOMERS SET NAME =@NAME,COUNTRY =@CNAME WHERE CustomerId=@id ", _sqlconn);
            _cmd.Parameters.AddWithValue("@NAME", sName);
            _cmd.Parameters.AddWithValue("@CNAME", CName);
            _cmd.Parameters.AddWithValue("@id", id);

            int _flag = int.Parse(_cmd.ExecuteNonQuery().ToString());

            return _flag;
        }
    }
}
