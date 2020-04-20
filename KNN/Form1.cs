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
        List<double> wprowadzonaProbka = new List<double>();
        Dictionary<double, List<double>> slownikOdleglosci = new Dictionary<double, List<double>>();
        Dictionary<double, double> slownikOdleglowciZParametrem = new Dictionary<double, double>();
        HashSet<double> listaKlasProbkowych = new HashSet<double>();

        int parametr = 3;
        public delegate double M(double[] probkaWzorcowa, List<double> probkaTestowa);
        M metryka = Metryki.metrykaEuklidesowa;


        private void wprowadzSciezkePlikuBtn_Click(object sender, EventArgs e)
        {
            sciezka = this.sciezkaPliku.Text;
            listaProbekZPliku = klasyfikator.wczytajzPliku(sciezka);
            if (checkBox1.Checked)
                klasyfikator.normalizuj(listaProbekZPliku);

            //dodanie kolumn do tabeli wyswietlajacej dane z pliku
            dodajKolumny(listaProbekZPliku, dataGridView1);

            this.wprowadzSciezkePlikuBtn.Enabled = false;
            this.wybierszPlikBtn.Enabled = false;

            this.label1.Visible = true;
            this.argument1.Visible = true;
            this.wprowadzArgumentyBtn.Visible = true;
            this.wyczyscProbkeBtn.Visible = true;

            this.checkBox1.Enabled = false;
            this.wprowadzParametrBtn.Enabled = true;

            this.jedenVsResztaBtn.Enabled = true;
        }

        private void wprowadzParametrBtn_Click(object sender, EventArgs e)
        {
            parametr = int.Parse(textBox1.Text);
        }

        private void wyczyscProbkeBtn_Click(object sender, EventArgs e)
        {
            wprowadzonaProbka.Clear();
            this.wprowadzArgumentyBtn.Enabled = true;
            // dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
                dataGridView2.Rows[0].Cells[i].Value = "";
        }

        private void wprowadzArgumentyBtn_Click(object sender, EventArgs e)
        {
            wprowadzonaProbka.Add(double.Parse(argument1.Text));
            dataGridView2.Rows[0].Cells[wprowadzonaProbka.Count - 1].Value = argument1.Text;
            argument1.Text = "";
            if (wprowadzonaProbka.Count == listaProbekZPliku[0].Length - 1)
                this.klasyfikujBtn.Enabled = true;
        }

        private void parametrMetrykiMinkowskiegoBtn_Click(object sender, EventArgs e)
        {
            Metryki.parametr_M = int.Parse(parametrMetrykiMinkowskiegoTextBox.Text);
            Console.WriteLine(Metryki.parametr_M);
        }

        private double klasyfikuj(List<double[]> listaElementowOdczytanychZPliku, List<double> probkaTestowa, int parametr_k, M metryka)
        {
            slownikOdleglosci.Clear();
            slownikOdleglowciZParametrem.Clear();
            listaKlasProbkowych = klasyfikator.listaKlasWzorcowych(listaElementowOdczytanychZPliku);

            foreach (double element in listaKlasProbkowych)
            {
                //dodanie do słownika klass wzorcowych i pustej listy
                slownikOdleglosci.Add(element, new List<double>());
                foreach (double[] tablica in listaElementowOdczytanychZPliku)
                    //dodanie do słownika odległości względem klasy
                    if (element == tablica[tablica.Length - 1])
                        slownikOdleglosci[element].Add(metryka(tablica, probkaTestowa));

                //posotrowanie listy
                slownikOdleglosci[element].Sort();
            }

            slownikOdleglowciZParametrem = klasyfikator.utworzSlownikOdleglowciZParametru(listaKlasProbkowych, slownikOdleglosci, parametr_k);
            double klasa = klasyfikator.klasaZNajmniejszaOdlegloscia(slownikOdleglowciZParametrem);

            dataGridView2.Rows[0].Cells[wprowadzonaProbka.Count].Value = klasa;
            return klasa;
        }

        private void klasyfikujBtn_Click(object sender, EventArgs e)
        {
            if (this.radioLogarytmem.Checked)
                metryka = Metryki.metrykaLogarytmem;
            else if (this.radioCzebyszewa.Checked)
                metryka = Metryki.metrykaCzebyszewa;
            else if (this.radioEuklidesowa.Checked)
                metryka = Metryki.metrykaEuklidesowa;
            else if (this.radioManhattan.Checked)
                metryka = Metryki.metrykaManhattan;
            else if (this.radioMinkowskiego.Checked)
                metryka = Metryki.metrykaMinkowskiego;

            double klasa = klasyfikuj(listaProbekZPliku, wprowadzonaProbka, parametr, metryka);
            //wyznaczenie klasy ktora ma najblizsza odleglosc
            if (klasa != 0.1)
            {
                this.klasyfikujLabel.Text = "Klasa: " + klasa;
            }
            else
                this.klasyfikujLabel.Text = "nie mozna sklasyfikowac probki";
        }

        private void jedenVsResztaBtn_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView3.Rows.Count - 1; j++)
                dataGridView3.Rows[j].Cells[listaProbekZPliku[j].Length].Value = klasyfikuj(listaProbekZPliku, listaProbekZPliku[j].ToList(), parametr, metryka);

            this.dokladnoscLabel.Text = "Dokładność 1 vs reszta: " + dokladnoscKlasyfikacji(dataGridView3).ToString() + " %"; ;
        }

        private double dokladnoscKlasyfikacji(DataGridView dataGridView)
        {
            double dokladnosc = 0;

            for (int j = 0; j < dataGridView.Rows.Count - 1; j++)
                if (dataGridView.Rows[j].Cells[listaProbekZPliku[j].Length].Value.Equals(dataGridView.Rows[j].Cells[listaProbekZPliku[j].Length - 1].Value))
                    dokladnosc += 1;
            return Math.Round((dokladnosc / (dataGridView.Rows.Count - 1)) * 100, 3);
        }

        private void dodajKolumny(List<double[]> listaProbekZPliku, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = listaProbekZPliku[0].Length;
            dataGridView2.ColumnCount = listaProbekZPliku[0].Length;
            dataGridView3.ColumnCount = listaProbekZPliku[0].Length + 1;
            for (int i = 0; i < listaProbekZPliku[0].Length - 1; i++)
            {
                dataGridView.Columns[i].Name = "arg " + i;
                dataGridView2.Columns[i].Name = "arg " + i;
                dataGridView3.Columns[i].Name = "arg " + i;
            }
            dataGridView2.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridView2.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView.Columns[listaProbekZPliku[0].Length - 1].Name = "klasa";
            dataGridView3.Columns[listaProbekZPliku[0].Length - 1].Name = "klasa";
            dataGridView3.Columns[listaProbekZPliku[0].Length].Name = "klasa 1vsreszta";
            dataGridView2.Columns[listaProbekZPliku[0].Length - 1].Name = "klasa";
            dodajWiersz(listaProbekZPliku, dataGridView);
            dodajWiersz(listaProbekZPliku, dataGridView3);
        }

        private void dodajWiersz(List<double[]> lista, DataGridView dataGridView)
        {
            foreach (double[] wiersz in lista)
            {
                object[] obj = new object[wiersz.Length];

                for (int i = 0; i < wiersz.Length; i++)
                {
                    obj[i] = wiersz[i];
                }
                //dodanie poszczegolnych wierszy
                dataGridView.Rows.Add(obj);
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;
            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8)
            {
                e.Handled = true;
            }
        }

        private void parametrMetrykiMinkowskiegoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;
            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8)
            {
                e.Handled = true;
            }
        }

        //wybor pliku za pomocą okienka
        private void wybierszPlikBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik z próbkami";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
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
            if (wprowadzonaProbka.Count != listaProbekZPliku[0].Length - 1 && !this.wprowadzSciezkePlikuBtn.Enabled)
            {
                if (argument1.Text != "")
                    this.wprowadzArgumentyBtn.Enabled = true;
                else
                    this.wprowadzArgumentyBtn.Enabled = false;
            }
            else
                this.wprowadzArgumentyBtn.Enabled = false;

        }

        private void radioMinkowskiego_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMinkowskiego.Checked)
            {
                this.parametrMetrykiMinkowskiegoBtn.Enabled = true;
                this.label6.Visible = true;
                this.parametrMetrykiMinkowskiegoTextBox.Visible = true;
                this.parametrMetrykiMinkowskiegoBtn.Visible = true;
            }
            else
            {
                this.parametrMetrykiMinkowskiegoBtn.Enabled = false;
                this.parametrMetrykiMinkowskiegoBtn.Enabled = false;
                this.label6.Visible = false;
                this.parametrMetrykiMinkowskiegoTextBox.Visible = false;
                this.parametrMetrykiMinkowskiegoBtn.Visible = false;
            }
        }

        private void argument1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && wprowadzArgumentyBtn.Enabled)
                wprowadzArgumentyBtn_Click(this, new EventArgs());
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
