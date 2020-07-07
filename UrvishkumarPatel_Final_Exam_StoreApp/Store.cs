using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrvishkumarPatel_Final_Exam_StoreApp
{
    static class Store
    {
        static int totalPrice = 0;
        public static List<Merchandise> forSale = new List<Merchandise>()
        {
            new Food(8,"Chicken"),
            new Food(2,"Rice"),
            new Food(5,"Bananas"),
            new Food(1,"Radishes"),
            new Food(3,"Samosa"),
            new Clothing(23,"Jeans"),
            new Clothing(4,"Socks"),
            new Clothing(13,"T-Shirts"),
            new Clothing(24,"Sandals"),
            new Clothing(19,"Sun Hat"),
            new Electronics(895,"Laptop"),
            new Electronics(195,"CellPhone"),
            new Electronics(45,"Headphones"),
            new Electronics(50,"Speakers"),
            new Electronics(10,"USB Cable")
        };
        public static List<Merchandise> shoppingCart = new List<Merchandise>()
        {

        };
    }
}
