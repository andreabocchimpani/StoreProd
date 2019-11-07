using StoreProd.TypeOfProduct;
using System;

namespace StoreProd
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book ("PRA07112019", "I promessi sposi", "Alessandro Manzoni", DateTime.Now, 540);
            //Console.WriteLine(b1.Description());
            //Console.WriteLine(b1.CalcPrice());

            Book b2 = new Book("PPD07112019", "Il piccolo principe", "Antoine de Saint Exupery", DateTime.Now, 80);
            //Console.WriteLine(b1.Description());
            //Console.WriteLine(b1.CalcPrice());

            Film f1 = new Film("AVP07112019", "Avengers", "Tizio Caio", DateTime.Now, 180);
            //Console.WriteLine(f1.Description());
            //Console.WriteLine(f1.CalcPrice());

            Film f2 = new Film("JOP07112019", "Joker", "Andrea Parodi", DateTime.Now, 90);
            //Console.WriteLine(f1.Description());
            //Console.WriteLine(f1.CalcPrice());
                

            Product[] products = {b1, b2, f1, f2 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Description());
            }

        }
    }
}
