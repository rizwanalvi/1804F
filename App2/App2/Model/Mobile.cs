using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Model
{
   public class Mobile
    {
        public int MobileId { get; set; }
        public String MobileName { get; set; }
        public String ImagePath { get; set; }
        private List<Mobile> _lsmb = null;
        public List<Mobile> GetAllMobile() {
            _lsmb = new List<Mobile>();
            _lsmb.Add(new Mobile {MobileId=1000,MobileName="Nokia 3",ImagePath= "Assets/01.jfif" });
            _lsmb.Add(new Mobile { MobileId = 1000, MobileName = "Nokia 3", ImagePath = "Assets/01.jfif" });
            _lsmb.Add(new Mobile { MobileId = 1000, MobileName = "Nokia 4", ImagePath = "Assets/01.jfif" });
            _lsmb.Add(new Mobile { MobileId = 1000, MobileName = "Nokia 5", ImagePath = "Assets/01.jfif" });
            _lsmb.Add(new Mobile { MobileId = 1000, MobileName = "Nokia 6", ImagePath = "Assets/01.jfif" });
            _lsmb.Add(new Mobile { MobileId = 1000, MobileName = "Nokia 7", ImagePath = "Assets/01.jfif" });
            _lsmb.Add(new Mobile { MobileId = 1000, MobileName = "Nokia 8", ImagePath = "Assets/01.jfif" });
            _lsmb.Add(new Mobile { MobileId = 1000, MobileName = "Nokia 9", ImagePath = "Assets/01.jfif" });

            return _lsmb;
        }
    }
}
