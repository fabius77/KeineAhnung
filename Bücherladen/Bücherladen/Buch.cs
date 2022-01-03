using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bücherladen
{
    public class Buch : Product
    {
        public string Author;
        public int Pages;
        public int Year;
        public string Country;
        public string Language;

        public Buch(string art, int nummer, string title, string author, int pages, int year, string country, string language, Guid id)
            :base(nummer, art, title, id)
        {
            Author = author;
            Pages = pages;
            Year = year;
            Country = country;
            Language = language;
        }
    }
}
