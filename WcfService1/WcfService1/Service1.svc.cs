using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public string EvenOrOdd(int a)
        {
            String da = "odd";
            if (a % 2 == 0)
                da = "even";

            return da;
        }

        public int Factorial(int a)
        {
            int fac = 1;
            for (int i = 1; i <= a; i++)
            {
                //fac = fac* i;
                fac *=i;
            }
            return fac;
        }

        int IService1.Subtraction(int a, int b)
        {
            return a - b; ;
        }
      
        
    }
}
