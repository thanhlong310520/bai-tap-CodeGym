using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLySanPhamLuuRaFileNhiPhan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            Product p1 = new Product { ID = "232ed", Name= "dfadfaf",Manufacturer =  "ffffffff", Price= 100000,Describe= "dffrererererewrerererwerewrewrerewrwerewrewr" };
            Product p2 = new Product { ID = "112ea", Name = "dfatfdafdf", Manufacturer = "aagfc", Price = 20, Describe = "gdfsgdfdfgdagdgdagdsgadsg" };
            Product p3= new Product("255ad", "fdfffasf", "gggg", 30, "gadgdgadgfdfgdfdsafa");
            Product p4= new Product("521aa", "dfadvzcvzfaf", "aa", 3444, "afdgfdgcsdgadsf");
            Product p5= new Product("345da", "cvyr", "dggdg", 233, "fgadgdasfdasfdgadsfdagsagdgfdg");

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            var productJson = JsonConvert.SerializeObject(list);
            List<Product> l3;

            string filePart = @"E:\CodeGym\bai tap CodeGym\File\QuanLySanPhamLuuRaFileNhiPhan\text.txt";
            try
            {
                FileStream file = new FileStream(filePart, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(productJson);
                writer.Close();
                file.Close();
            }
            catch
            {
                Console.WriteLine("khong mo duoc file");
            }
            try
            {
                FileStream file = new FileStream(filePart, FileMode.Open, FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(file);
                l3 = JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
                foreach (Product temp in l3)
                {
                    Console.WriteLine("san pham");
                    Console.WriteLine(temp.ToString());
                    Console.WriteLine("-------------------------------------------------");
                }
                reader.Close();
                file.Close();
            }
            catch
            {
                Console.WriteLine("khong mo duoc file");
            }
            //var l2 = JsonConvert.DeserializeObject<List<Product>>(productJson);

            //foreach (Product temp in l2)
            //{
            //    Console.WriteLine("san pham");
            //    Console.WriteLine(temp.ToString());
            //    Console.WriteLine("-------------------------------------------------");
            //}
        }
    }
    [Serializable]
    public class Product
    {
        string id;
        string name;
        string manufacturer;
        double price;
        string describe;

        public Product()
        {
        }

        public Product(string iD, string name, string manufacturer, double price, string describe)
        {
            this.id = iD;
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Describe = describe;
        }

        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Price { get => price; set => price = value; }
        public string Describe { get => describe; set => describe = value; }

        public override string ToString()
        {
            return $"san pham {id} co ten la {Name} - nha san suat la {Manufacturer} - voi gia la {Price} : mo ta: {Describe}";
        }
    }
}
