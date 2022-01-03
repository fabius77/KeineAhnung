using System;
using System.Collections.Generic;
using System.Text;

namespace Bücherladen
{
    class ExemplarMagazin
    {
        public int Nummer;
        public string Title;
        public Guid MagazinId;
        public int Exemplare;
        public int AnzahlVerliehen;

        public ExemplarMagazin(int nummer, Guid magazinId, string title, int exemplare)
        {
            Nummer = nummer;
            MagazinId = magazinId;
            Title = title;
            Exemplare = exemplare;
        }
    }
}
