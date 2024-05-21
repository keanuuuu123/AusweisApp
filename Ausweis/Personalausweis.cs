/*
Es soll eine abgeleitete Klasse Personalausweis definiert werden. Diese Klasse erbt
Inhaber, Ausweisnummer und Ablaufdatum. Wenn ein Personalausweis erstellt wird,
müssen für die/den Inhaber*in, für Ausweisnummer und Ablaufdatum Werte
vergeben werden. Ein Personalausweis hat zudem einen digitalen Fingerabdruck.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweis
{
    public class Personalausweis : Ausweis
    {
        public Fingerabdruck Fingerprint { get; set; }

        public Personalausweis(Inhaber owner, int ausweisnummer, DateOnly ablaufdatum, Fingerabdruck fingerprint) : base(owner, ausweisnummer, ablaufdatum)
        {
            Fingerprint = fingerprint;
        }
        public override string ToString()
        {
            
            Console.WriteLine($"Digitaler Fingerabdruck: {Fingerprint}\n");
            return base.ToString();
        }
    }
}
