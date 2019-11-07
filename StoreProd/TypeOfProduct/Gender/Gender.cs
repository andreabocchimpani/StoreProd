using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProd.TypeOfProduct.Gender
{
    internal abstract class Gender
    {
        public string Name { get; }
        public int Viewed { get; set; } //Prodotto visto x volte

        protected Gender(string name, int viewed)
        {
            Name = name;
            Viewed = viewed;
        }

        public string getViewedString()
        {
            return Viewed.ToString("C2");
        }

    }
}
