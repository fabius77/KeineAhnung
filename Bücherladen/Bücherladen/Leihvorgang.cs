using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace Bücherladen
{
    public class Leihvorgang
    {
        public Guid Id;
        public int Nummer;
        public string Title;
        public string VerliehenAm;
        public int Leihdauer;
        public string Kunde;
        public string VerfugbarAb;
        public Guid BuchId;

        public Leihvorgang(Guid id, int nummer, string title, string kunde, Guid buchId)
        {
            Id = id;
            Nummer = nummer;
            Title = title;
            Kunde = kunde;
            BuchId = buchId;
            Leihdauer = 30;
            VerliehenAm = DateTime.Now.ToString("dd/MM/yyyy");
            VerfugbarAb = DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");
        }
    }
}
