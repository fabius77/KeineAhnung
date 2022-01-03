using System;
using System.Collections.Generic;
using System.Text;

namespace Bücherladen
{
    public class Magazin : Product
    {
        public string Gruppe;
        public string Sachgruppe;
        public string Verlag;

        public Magazin(string art, int nummer, string title, string gruppe, string sachgruppe, string verlag, Guid id)
            :base(nummer, art, title, id)
        {
            Gruppe = gruppe;
            Sachgruppe = sachgruppe;
            Verlag = verlag;
        }
    }
}
