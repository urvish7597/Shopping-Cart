using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrvishkumarPatel_Final_Exam_StoreApp
{
    class Food:Merchandise
    {
        public Food(int price, string item) : base(price, item)
        {
        }
        public override string ReturnItemInfo()
        {
            return base.ReturnItemInfo()+" is merchandise from food department. Sale is final.";
        }
    }
}
