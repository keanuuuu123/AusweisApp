/*
Es soll eine Klasse Inhaber definiert werden. Ein Inhaber soll einen Vornamen,
Nachnamen, gemeldeten Wohnort, eine Augenfarbe, eine Körpergröße und ein
Geburtsdatum haben.
Die Klasse Ausweis steht mit der Klasse Inhaber durch
Komposition in Beziehung
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ausweis
{
    public class Inhaber
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Wohnort { get; set; }
        public string Augenfarbe { get; set; }
        public int Koerpergroesse { get; set; }
        public DateOnly Geburtsdatum { get; set; }

        public Inhaber(string vorname, string nachname, string wohnort, string augenfarbe, int koerpergroesse, DateOnly geburtsdatum)
        {
            Vorname = vorname;
            Nachname = nachname;
            Wohnort = wohnort;
            Augenfarbe = augenfarbe;
            Koerpergroesse = koerpergroesse;
            Geburtsdatum = geburtsdatum;
        }
        public override string ToString()
        {
            Console.WriteLine($"Vorname: {Vorname}\nNachname: {Nachname}\nWohnort: {Wohnort}\nAugenfarbe: {Augenfarbe}\nKörpergröße(cm): {Koerpergroesse}\nGeburtsdatum: {Geburtsdatum}\n");
            return base.ToString();
        }
    }
}