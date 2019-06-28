using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNeed01
{
    class Program
    {
        static void Main(string[] args)
        {
            mobiledbEntities dbEntity = new mobiledbEntities();
            var objList = dbEntity.MOBDATAs;
            foreach (var item in objList)
            {
                Console.WriteLine(item.MNAME);

            }

            MOBDATA db = new MOBDATA();
            db = dbEntity.MOBDATAs.Where(x => x.ID == 1).Single();
            db.MNAME = "Apple Mango Orange";
            dbEntity.SaveChanges();
           
            
            
            // dbEntity.MOBDATAs.Add(new MOBDATA {BRAND_ID=1,MNAME="majid Mobile",PRICE=450.40 });
            //dbEntity.SaveChanges();
            Console.Read();
        }
    }
}
