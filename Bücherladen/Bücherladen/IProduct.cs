using System;

namespace Bücherladen
{
    public interface IProduct
    {
        public int Nummer { get; set; }
        public string Title { get; set; }
        public Guid Id { get; }


        string Load(string pfad);

        void Save(string pfad, string jsonString);
    }
}
