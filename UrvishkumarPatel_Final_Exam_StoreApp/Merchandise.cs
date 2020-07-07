using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrvishkumarPatel_Final_Exam_StoreApp
{
    abstract class Merchandise
    {
        private static int serialNumberCounter = 0;
        public int Price { get; set; }
        public string Item { get; set; }
        public int SerialNumber { get; set; }

        public Merchandise(int _price,string _item)
        {
            this.Price = _price;
            this.Item = _item;
            SerialNumber = serialNumberCounter;
            serialNumberCounter++;
        }

        public virtual string ReturnItemInfo() 
        {
            return Item;
        }
    }
}
