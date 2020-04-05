using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Klasyfikator klasyfikator = new Klasyfikator();
        Metryki metryki = new Metryki();
        string sciezka = "";
        //string sciezkaPl = @"C:\Users\szymo\source\repos\ConsoleKNN\iris.txt";
        List<double[]> listaProbekZPliku = new List<double[]>();
        HashSet<double> listaKlasProbkowych = new HashSet<double>();
        List<double> wprowadzonaProbka = new List<double>();
        int parametr = 3;
        Dictionary<double, List<double>> slownikOdleglosci = new Dictionary<double, List<double>>();
        Dictionary<double, double> slownikOdleglowciZParametrem = new Dictionary<double, double>();
       

        private void wprowadzSciezkePlikuBtn_Click(object sender, EventArgs e)
        {
            sciezka = this.sciezkaPliku.Text;
            listaProbekZPliku = klasyfikator.wczytajzPliku(sciezka);

            listaKlasProbkowych = klasyfikator.listaKlasWzorcowych(listaProbekZPliku);
            //dodanie kolumn do tabeli wyswietlajacej dane z pliku
            dodajKolumny(listaProbekZPliku);
            dodajWiersz(listaProbekZPliku);


            this.wprowadzSciezkePlikuBtn.Enabled = false;
            this.wybierszPlikBtn.Enabled = false;
        }

        private void wprowadzArgumentyBtn_Click(object sender, EventArgs e)
        {
            wprowadzonaProbka.Clear();
            wprowadzonaProbka.Add(double.Parse(argument1.Text));
            wprowadzonaProbka.Add(double.Parse(argument2.Text));
            wprowadzonaProbka.Add(double.Parse(argument3.Text));
            wprowadzonaProbka.Add(double.Parse(argument4.Text));
            Console.WriteLine(argument1.Text + argument2.Text +argument3.Text+argument4.Text);
            
            this.obliczBtn.Enabled = true;
        }

        private void obliczBtn_Click(object sender, EventArgs e)
        {
            this.klasyfikujBtn.Enabled = true;
            slownikOdleglosci = utworzSlownikOdleglosci(listaKlasProbkowych, listaProbekZPliku, wprowadzonaProbka);
            foreach (KeyValuePair<double, List<double>> u in slownikOdleglosci)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Klasa = {0} ", u.Key);
                foreach (double p in u.Value)
                {
                    Console.WriteLine("metryka: {0}", p);
                }
            }

            slownikOdleglowciZParametrem = klasyfikator.utworzSlownikOdleglowciZParametru(listaKlasProbkowych, slownikOdleglosci, parametr);
            foreach (KeyValuePair<double, double> u in slownikOdleglowciZParametrem)
            {
                Console.WriteLine("Klasa = {0} odległosc: {1}", u.Key, u.Value);
            }

        }


        private void klasyfikujBtn_Click(object sender, EventArgs e)
        {
            //wyznaczenie klasy ktora ma najblizsza odleglosc
            if (!klasyfikator.czyTakieSameWartosci(slownikOdleglowciZParametrem))
            {
                double klasa = 1;
                double odleglosc = slownikOdleglowciZParametrem[klasa];

                foreach (KeyValuePair<double, double> u in slownikOdleglowciZParametrem)
                {
                    if (odleglosc > u.Value)
                    {
                        odleglosc = u.Value;
                        klasa = u.Key;
                    }
                }
                this.klasyfikujLabel.Text = "Klasa: " + klasa;
            }
            else
                this.klasyfikujLabel.Text = "nie mozna sklasyfikowac probki";

        }

        private void dodajKolumny(List<double[]> listaProbekZPliku)
        {
            dataGridView1.ColumnCount = listaProbekZPliku[0].Length;
            for (int i = 0; i < listaProbekZPliku[0].Length - 1; i++)
            {
                dataGridView1.Columns[i].Name = "arg " + i;
            }            
            dataGridView1.Columns[listaProbekZPliku[0].Length - 1].Name = "klasa";            
        }

        private void dodajWiersz(List<double[]> listaProbekZPliku)
        {
            foreach (double[] wiersz in listaProbekZPliku)
            {
                object[] obj = new object[wiersz.Length];

                for (int i = 0; i < wiersz.Length; i++)
                {
                    obj[i] = wiersz[i];
                }
                //dodanie poszczegolnych wierszy
                dataGridView1.Rows.Add(obj);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        private Dictionary<double, List<double>> utworzSlownikOdleglosci(HashSet<double> listaKlasProbkowych, List<double[]> listaElementowOdczytanychZPliku, List<double> probkaTestowa)
        {
            Dictionary<double, List<double>> slownikOdleglosci = new Dictionary<double, List<double>>();

            foreach (double element in listaKlasProbkowych)
            {
                //dodanie do słownika klass wzorcowych i pustej listy
                slownikOdleglosci.Add(element, new List<double>());
                foreach (double[] tablica in listaElementowOdczytanychZPliku)
                {
                    //dodanie do listy klasy odleglosci
                    if (element == tablica[tablica.Length - 1])
                    {
                        if(this.radioLogarytmem.Checked)
                            slownikOdleglosci[element].Add(metryki.metrykaLogarytmem(tablica, probkaTestowa));
                        else if (this.radioCzebyszewa.Checked)
                            slownikOdleglosci[element].Add(metryki.metrykaCzebyszewa(tablica, probkaTestowa));
                        else if (this.radioEuklidesowa.Checked)
                            slownikOdleglosci[element].Add(metryki.metrykaEuklidesowa(tablica, probkaTestowa));
                        else if (this.radioManhattan.Checked)
                            slownikOdleglosci[element].Add(metryki.metrykaManhattan(tablica, probkaTestowa));
                        else if (this.radioMinkowskiego.Checked)
                            slownikOdleglosci[element].Add(metryki.metrykaMinkowskiego(tablica, probkaTestowa, 2));//parametr
                    }
                }
                //posotrowanie listy
                slownikOdleglosci[element].Sort();
            }
            return slownikOdleglosci;
        }

        //walidacja do wprowadzania tylko liczb
        private void argument1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;
            if (wprowadzonaLiczba == 44 && argument1.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8 && wprowadzonaLiczba != 44)
            {
                e.Handled = true;
            }
        }

        private void argument2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;
            if (wprowadzonaLiczba == 44 && argument2.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8 && wprowadzonaLiczba != 44)
            {
                e.Handled = true;
            }
        }

        private void argument3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;
            if (wprowadzonaLiczba == 44 && argument3.Text.IndexOf(',') != -1)
            {
                e.Handled = true;              
                return;
            }

            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8 && wprowadzonaLiczba != 44)
            {
                e.Handled = true;
            }
        }

        private void argument4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;
            if (wprowadzonaLiczba == 44 && argument4.Text.IndexOf(',') != -1)
            {
                e.Handled = true;               
                return;
            }

            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8 && wprowadzonaLiczba != 44)
            {
                e.Handled = true;
            }
        }


        //wybor pliku za pomocą okienka
        private void wybierszPlikBtn_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik z próbkami";
           
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezka = openFileDialog.FileName;
                this.sciezkaPliku.Text = sciezka;
            }
        }


        //aktywowanie przycisku po wpisaniu argumentów
        private void argument1_TextChanged(object sender, EventArgs e)
        {
            if (argument1.Text != "" && argument2.Text != "" && argument3.Text != "" && argument4.Text != "")
                this.wprowadzArgumentyBtn.Enabled = true;
            else
                this.wprowadzArgumentyBtn.Enabled = false;
        }

        private void argument2_TextChanged(object sender, EventArgs e)
        {
            if (argument1.Text != "" && argument2.Text != "" && argument3.Text != "" && argument4.Text != "")
                this.wprowadzArgumentyBtn.Enabled = true;
            else
                this.wprowadzArgumentyBtn.Enabled = false;
        }

        private void argument3_TextChanged(object sender, EventArgs e)
        {
            if (argument1.Text != "" && argument2.Text != "" && argument3.Text != "" && argument4.Text != "")
                this.wprowadzArgumentyBtn.Enabled = true;
            else
                this.wprowadzArgumentyBtn.Enabled = false;
        }

        private void argument4_TextChanged(object sender, EventArgs e)
        {
            if (argument1.Text != "" && argument2.Text != "" && argument3.Text != "" && argument4.Text != "")
                this.wprowadzArgumentyBtn.Enabled = true;
            else
                this.wprowadzArgumentyBtn.Enabled = false;
        }
    }
}
