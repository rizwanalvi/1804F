using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webmvc02.Models
{
    public class Mobile
    {
        public int MobileId { get; set; }
        public String MobileName { get; set; }
        public String ImagePath { get; set; }

        private List<Mobile> _mob = null;
        public List<Mobile> GetAllMobile() {
            _mob = new List<Mobile>();
            _mob.Add(new Mobile { MobileId=1,MobileName="Nokia 3", ImagePath= "/img/01.jfif" });
            _mob.Add(new Mobile { MobileId = 2, MobileName = "Nokia 3", ImagePath = "/img/01.jfif" });
            _mob.Add(new Mobile { MobileId = 3, MobileName = "Nokia 3", ImagePath = "/img/01.jfif" });
            _mob.Add(new Mobile { MobileId = 4, MobileName = "Nokia 3", ImagePath = "/img/01.jfif" });
            _mob.Add(new Mobile { MobileId = 5, MobileName = "Nokia 3", ImagePath = "/img/01.jfif" });
            _mob.Add(new Mobile { MobileId = 6, MobileName = "Nokia 3", ImagePath = "/img/01.jfif" });
            _mob.Add(new Mobile { MobileId = 7, MobileName = "Nokia 3", ImagePath = "/img/01.jfif" });
            return _mob;
        }
    }
}