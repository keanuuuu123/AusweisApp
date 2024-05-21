/*
Es soll eine abstrakte Klasse Ausweis definiert werden. Ein Ausweis hat eine/n
Inhaber*in, eine Ausweisnummer und ein Ablaufdatum.
Die Klasse Ausweis steht mit der Klasse Inhaber durch
Komposition in Beziehung
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweis
{
    public  class Ausweis
    {
        public Inhaber Owner { get; set; }
        public int Ausweisnummer { get; set; }
        public DateOnly Ablaufdatum { get; set; }

        public Ausweis(Inhaber owner, int ausweisnummer, DateOnly ablaufdatum)
        {
            Owner = owner;
            Ausweisnummer = ausweisnummer;
            Ablaufdatum = ablaufdatum;
        }
    }
}
