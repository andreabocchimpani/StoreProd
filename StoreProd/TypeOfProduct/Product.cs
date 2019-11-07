using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProd.TypeOfProduct
{
    internal abstract class Product
    {
        public string Id { get; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PubblicationDate { get; set; }


        //Costruttore che prende in pasto tutti i dati
        public Product(string id, string name, string author, DateTime pubblicationDate ) 
        {
            Id = id;
            Name = name;
            Author = author;
            PubblicationDate = pubblicationDate;
        }

        //Costruttore che prende in pasto solo nome e autore
        public Product(string name, string author)
        {
            Name = name;
            Author = author;
        }


        //Metodi

        private string CreateId(string name, string author, DateTime pubblicationDate)
        {
            string formattedDate = pubblicationDate.ToString("ddMMyyyyHHmmss");
            return name[0].ToString() + author[0].ToString() + formattedDate;
        }


        public string Description()
        {
            string description = "Id: " + Id + "\n"
                                + "Nome: " + Name + "\n"
                                + "Autore: " + Author + "\n"
                                + "Data di pubblicazione: " + PubblicationDate + "\n";
                                
            return description;
        }

        public abstract double CalcPrice();
        

    }
}
