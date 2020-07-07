using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrvishkumarPatel_Final_Exam_StoreApp
{
    class Clothing:Merchandise
    {
        public Clothing(int price, string item) : base(price, item)
        {
        }
        public override string ReturnItemInfo()
        {
            return base.ReturnItemInfo() + " is merchandise from clothing department. Sale is final.";
        }
    }
}
