using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_HomeWork.Models
{
    internal class Notebook:Product
    {
        //Fields
        private string _brand;
        private string _model;
        private byte _ram;
        private int _storage;

        //Propertys
        public string Brand
        {
            get => _brand;
            set
            {
                if (value.Length < 31 && value.Length > 2)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Brand name is wrong!!");
                }
            }
        }
        public string Model
        {
            get => _model;
            set
            {
                if (value.Length < 31 && value.Length > 2)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Model name is wrong!!");
                }
            }
        }
        public byte Ram
        {
            get => _ram;
            set
            {
                if (value >=0 && value<=128)
                {
                    _ram = value;
                }
                else
                {
                    Console.WriteLine("Ram is wrong!!");
                }
            }
        }
        public int Storage
        {
            get => _storage;
            set
            {
                if (value >= 0)
                {
                    _storage = value;
                }
                else
                {
                    Console.WriteLine("Storage is wrong!!");
                }
            }
        }


        //Constructors
        public Notebook(int count, int Price, string Model) : base(count,Price)
        {
            this.Model=Model;            
        }
        public Notebook(string Model,string Brand, int count, int Price) : this(count, Price,Model)
        {
            this.Brand = Brand;
        }
        public Notebook(string Model, string Brand, byte Ram, int count, int Price) : this(Model, Brand, count, Price)
        {
            this.Ram = Ram;
        }
        public Notebook(string Model, string Brand, byte Ram,int Storage, int count, int Price) :this(Model,Brand,Ram,count,Price)
        {
            this.Storage = Storage;
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"Brand: {_brand}\nModel: {_model}\nStorage: {_storage}\nRam: {_ram}\nPrice: {_price}\nCount: {_count}");
        }
    }
}
