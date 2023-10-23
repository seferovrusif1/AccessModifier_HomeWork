using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_HomeWork.Models
{
    internal class Product
    {
        //fields
        protected int _count;
        protected int _price;

        //Constructors
        public Product(int Count, int Price)
        {
            _count = Count;
            this.Price = Price;
        }
        //Property
        public int Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price is wrong!!");
                }
            }
        }
    }
}
