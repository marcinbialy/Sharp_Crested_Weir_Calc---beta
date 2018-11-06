using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WydatekLibrary;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrzelewUI
{
    public partial class PrzelewViewerForm : Form
    {
        public PrzelewViewerForm()
        {
            InitializeComponent();

            Wykres.Series["Wydatek"].Points.AddXY(0, 0);
            Wykres.Series["Wydatek"].Points.AddXY(1, 1);
            Wykres.Series["Wydatek"].Points.AddXY(2, 2);
            Wykres.Series["Wydatek"].Points.AddXY(3, 3);
            Wykres.Series["Wydatek"].Points.AddXY(4, 4);
        }

        private void label8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.RotateTransform(-90);
        }

        private void ObliczButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) // jeżli walidacja się powiodła
            {
                PrzelewModel model = new PrzelewModel(PgValue.Text, bValue.Text); // tworzenie modelu
                                                                                  // trzeba było to sparsować w modelu, dane na double ze stringa
                PrzelewLogic.WynikiObliczen(model); // połączenie z obliczeniami dla podanych danych w modelu

                Wykres.Series["Wydatek"].Points.Clear();

                var z = new List<Tuple<double, double>>(); // załadowanie nowej listy 
                z = PrzelewLogic.WynikiObliczen(model); // wczytanie danych do listy z obliczeń

                double[] Q = z.Select(t => Math.Round(t.Item1, 3)).ToArray(); // przeniesienie wyników listy do taablicy
                double[] H = z.Select(t => Math.Round(t.Item2 , 2)).ToArray();

                // przekazanie danych na wykres
                Wykres.Series["Wydatek"].Points.DataBindXY(Q, H);
            }
            else
            {
                MessageBox.Show("Wypełnij pola poprawnie!");
            }
        }

        private bool ValidateForm()// walidacja wprowadzanych danych
        {
            bool output = true; // ustawienie flagi
            bool PgNumberValidNumber = double.TryParse(PgValue.Text, out double PgNumber); //parsowanie tekstu na float
            bool bNumberValidNumber = double.TryParse(bValue.Text, out double bNumber);

            if (!PgNumberValidNumber || !bNumberValidNumber) // sprawdzenie czy było parsowanie
            {
                output = false;
            }

            if (PgNumber <= 0.10 || bNumber <= 0.15) // sprawdzenie dodatkowych warunków
            {
                output = false;
            }

            if(PgValue.Text.Length == 0 || bValue.Text.Length == 0) // sprawdzenie wprowadzenia danych
            {
                output = false;
            }
            return output;
        }

        private void GenerujButton_Click(object sender, EventArgs e)  // generowanie pliku wynikowego
        {
            PrzelewModel model = new PrzelewModel(PgValue.Text, bValue.Text);
            PrzelewLogic.GenerujPlik(model);
        }

        private void Wykres_MouseMove(object sender, MouseEventArgs e) // odczytywanie wartości z wykresu
        {
            Point mousePoint = new Point(e.X, e.Y);

            // ustawienie poczatkowe kursora myszy
            Wykres.ChartAreas[0].CursorX.Interval = 0;
            Wykres.ChartAreas[0].CursorY.Interval = 0;

            // krzyż pikselowej pozycji kursora
            Wykres.ChartAreas[0].CursorX.SetCursorPixelPosition(mousePoint, true);
            Wykres.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);

            // najechanie na krzywą kursorem - hit test
            HitTestResult result = Wykres.HitTest(e.X, e.Y);

            // warunek hit testu jeżeli jest rezultat i jeżeli jesteś na powierzchni wykresu
            if(result.PointIndex > -1 && result.ChartArea != null)
            {
                // odczytywanie wartości z wykresu
                label11.Text = "H [m] = " + result.Series.Points[result.PointIndex].YValues[0].ToString();
                label12.Text = "Q [m3/s] = " + result.Series.Points[result.PointIndex].XValue.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
