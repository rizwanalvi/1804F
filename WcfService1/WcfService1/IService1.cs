using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
   
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Addition(int a, int b);

        [OperationContract]
        int Subtraction(int a, int b);
        [OperationContract]
        int Factorial(int a);

        [OperationContract]
        string EvenOrOdd(int a);
      
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
  
}
