using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace WydatekLibrary
{
    public static class PrzelewLogic
    {

        public static List<Tuple<double, double>> WynikiObliczen(PrzelewModel model)
        { 
            List<Tuple<double, double>> ListaWynikow = Obliczenia(model.WysokoscProgu, model.SzerokoscPrzelewu, model.WysokoscWarstwyPrzelewowej, model.Wydatek);

            return ListaWynikow;
        }

        public static void GenerujPlik(PrzelewModel model) // zapisanie pliku na dysku po kliknięciu buttona Generuj plik
        {
            List<Tuple<double, double>> ListaWynikow = Obliczenia(model.WysokoscProgu, model.SzerokoscPrzelewu, model.WysokoscWarstwyPrzelewowej, model.Wydatek);
            SaveToFile(ListaWynikow, model);
        }

        public static string FullFilePath() //ścieżkazpisu pliku
        {
            string Path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\WynikiObliczen.csv";
            return Path;
        }

        public static void SaveToFile(List<Tuple<double,double>> lista, PrzelewModel model) //zapis do pliku
        {
            List<string> lines = new List<string>();
            
            lines.Add("Obliczenia wykonano dla danych:");
            lines.Add($"Pg =,{model.WysokoscProgu}");
            lines.Add($"b=,{model.SzerokoscPrzelewu}");
            lines.Add("");
            lines.Add($"Q[m3/s],H[m]");
            foreach (var p in lista)
            {
                lines.Add($"{p.Item1},{p.Item2}");
            }
            File.WriteAllLines(FullFilePath(), lines);
        }

        public static List<Tuple<double, double>>  Obliczenia(double Pg, double b, double H, double w) // przeprowadzenie obliczeń
        {
            var Q = new List<Tuple<double, double>>();
            const double PrzysZiemskie = 9.81;
            
           while (H <= 2 * Pg) // pętla obliczająca kolejne napełnienia po 1 cm
            {
                    w = (0.405 + 0.003 / H) * (1 + 0.55 * Math.Pow((H / (H + Pg)), 2)) * b * Math.Sqrt(2 * PrzysZiemskie) * Math.Pow(H, 1.5);
                    Q.Add(new Tuple<double, double>(w, H));

                    H += 0.01;
            }
            // zwrócenie listy wyników do stworzonej listy double
            return Q;
        }
        
    }
}
