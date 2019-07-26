using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataBinding.Model
{
   public class Fruit
    {
        public int FruitID { get; set; }
        public String FruitName { get; set; }
        public String Season { get; set; }
        public double Price { get; set; }
        public String ImagePath { get; set; }

        private List<Fruit> _lstfruit = null;
        public List<Fruit> GetAllFruits() {
            _lstfruit = new List<Fruit>();
            _lstfruit.Add(new Fruit { FruitID=1,FruitName="Orange",Season="Winter",Price=12.20,ImagePath= "assets/dafadf.jpg" });
            _lstfruit.Add(new Fruit { FruitID = 2, FruitName = "Apple", Season = "Winter", Price = 12.20, ImagePath = "assets/dafadf.jpg" });
            _lstfruit.Add(new Fruit { FruitID = 3, FruitName = "Mango", Season = "Winter", Price = 12.20, ImagePath = "assets/dafadf.jpg" });
            _lstfruit.Add(new Fruit { FruitID = 4, FruitName = "Pineapple", Season = "Winter", Price = 12.20, ImagePath = "assets/dafadf.jpg" });


            return _lstfruit;

        }
    }
}
