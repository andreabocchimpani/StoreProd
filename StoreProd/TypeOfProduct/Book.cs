using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProd.TypeOfProduct
{
    internal class Book : Product
    {
        public int PageNumber { get; set; }

        public Book (string id, string name, string author, DateTime pubblicationDate, int pageNumber) 
            : base(id, name, author, pubblicationDate)
        {
            PageNumber = pageNumber;
        }

        public override double CalcPrice()
        {
            if (PageNumber > 200)
                return 19.99;
            return 13.99;
        }
    }


}
