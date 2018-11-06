using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WydatekLibrary
{
    public class PrzelewModel
    {
        
        public double WysokoscProgu { get; set; }
        public double SzerokoscPrzelewu { get; set; }
        public double WysokoscWarstwyPrzelewowej { get; set; } = 0.01;
        public double Wydatek { get; set; } = 0;


        public PrzelewModel()
        {

        }

        public PrzelewModel(string PgValue, string bValue)
        {
            double.TryParse(PgValue, out double wysProguPg);
            WysokoscProgu = wysProguPg;

            double.TryParse(bValue, out double szerPrzelewub);
            SzerokoscPrzelewu = szerPrzelewub;
        }

    }
}
