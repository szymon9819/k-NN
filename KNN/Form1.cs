using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string sciezka = "";       
        List<double[]> listaProbekZPliku = new List<double[]>();
        HashSet<double> listaKlasProbkowych = new HashSet<double>();
        List<double> wprowadzonaProbka = new List<double>();
        int parametr = 6;
        Dictionary<double, List<double>> slownikOdleglosci = new Dictionary<double, List<double>>();
        Dictionary<double, double> slownikOdleglowciZParametrem = new Dictionary<double, double>();
        delegate double M(double[] probkaWzorcowa, List<double> probkaTestowa);
        M metryka;      

        //zmienne do aktywacji przycisku obliczajacego odległosć
        bool kliknecie1, klikniecie2 = false;

        private void wprowadzSciezkePlikuBtn_Click(object sender, EventArgs e)
        {
            sciezka = this.sciezkaPliku.Text;
            listaProbekZPliku = klasyfikator.wczytajzPliku(sciezka);
            if (checkBox1.Checked)
                klasyfikator.normalizuj(listaProbekZPliku);

            listaKlasProbkowych = klasyfikator.listaKlasWzorcowych(listaProbekZPliku);
            //dodanie kolumn do tabeli wyswietlajacej dane z pliku
            dodajKolumny(listaProbekZPliku);
            dodajWiersz(listaProbekZPliku);

            this.wprowadzSciezkePlikuBtn.Enabled = false;
            this.wybierszPlikBtn.Enabled = false;
            kliknecie1 = true;

            if (kliknecie1 && klikniecie2)
                this.obliczBtn.Enabled = true;

            this.checkBox1.Enabled = false;
        }

        private void wprowadzArgumentyBtn_Click(object sender, EventArgs e)
        {
            wprowadzonaProbka.Clear();
            wprowadzonaProbka.Add(double.Parse(argument1.Text));
            wprowadzonaProbka.Add(double.Parse(argument2.Text));
            wprowadzonaProbka.Add(double.Parse(argument3.Text));
            wprowadzonaProbka.Add(double.Parse(argument4.Text));
                    
            klikniecie2 = true;

            if (kliknecie1 && klikniecie2)
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
             this.klasyfikujBtn.Enabled = true;                     
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

            if (this.radioLogarytmem.Checked)
                metryka = Metryki.metrykaLogarytmem;
            else if (this.radioCzebyszewa.Checked)
                metryka = Metryki.metrykaCzebyszewa;
            else if (this.radioEuklidesowa.Checked)
                metryka = Metryki.metrykaEuklidesowa;
            else if (this.radioManhattan.Checked)
                metryka = Metryki.metrykaManhattan;

            foreach (double element in listaKlasProbkowych)
            {
                //dodanie do słownika klass wzorcowych i pustej listy
                slownikOdleglosci.Add(element, new List<double>());
                foreach (double[] tablica in listaElementowOdczytanychZPliku)
                {
                    //dodanie do słownika odległości względem klasy
                    if (element == tablica[tablica.Length - 1])
                    {                        
                        if (this.radioMinkowskiego.Checked)
                            slownikOdleglosci[element].Add(Metryki.metrykaMinkowskiego(tablica, probkaTestowa,3));
                        else
                            slownikOdleglosci[element].Add(metryka(tablica, probkaTestowa));
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
                if (Path.GetExtension(openFileDialog.FileName) != ".txt")
                {
                    MessageBox.Show("Plik musi być w formacie txt");
                    return;
                }
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

        private void sciezkaPliku_TextChanged(object sender, EventArgs e)
        {           
            if (sciezkaPliku.Text.Trim() == "")
                this.wprowadzSciezkePlikuBtn.Enabled = false;
            else
                this.wprowadzSciezkePlikuBtn.Enabled = true;
        }
    }
}
