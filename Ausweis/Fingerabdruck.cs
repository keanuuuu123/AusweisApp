/*
Ein digitaler Finderabdruck muss hierfür erstellt werden können, wofür eine weitere
Klassendefintion Fingerabdruck nötig ist. Ein Fingerabdruck soll erstmal nur eine iD
haben. Die Klasse Personalausweis steht durch Aggregation mit der Klasse
Fingerabdruck in Beziehung stehen.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweis
{
    public class Fingerabdruck
    {
        public int iD { get; set; }

        public Fingerabdruck(int iD)
        {
            this.iD = iD;
        }
        public override string ToString()
        {
            Console.WriteLine($"Fingerabdruck_ID: {iD}");
            return base.ToString();
        }
    }
}
