using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProd.TypeOfProduct
{
    class Film : Product
    {
        public int FilmLength { get; set; }

        public Film(string id, string name, string author, DateTime pubblicationDate, int filmLength)
            : base(id, name, author, pubblicationDate)
        {
            FilmLength = filmLength;
        }

        public override double CalcPrice()
        {
            if (FilmLength > 100)
                return 22.99;
            return 18.99;
        }
    }
}
