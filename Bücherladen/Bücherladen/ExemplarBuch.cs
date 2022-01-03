using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Bücherladen
{
    public class ExemplarBuch
    {
        public int Nummer;
        public string Title;
        public Guid BuchId;
        public int Exemplare;
        public int AnzahlVerliehen;

        public ExemplarBuch(int nummer, Guid buchId, string title, int exemplare)
        {
            Nummer = nummer;
            BuchId = buchId;
            Title = title;
            Exemplare = exemplare;
        }
    }
}
