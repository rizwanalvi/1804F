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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int InsertData(String sName,String CName);
        [OperationContract]
        int UpdateData(int id,String sName, String CName);

        [OperationContract]
        SqlDataReader SelectAll();
    }
    
}
