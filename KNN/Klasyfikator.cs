using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN
{

    class Klasyfikator
    {
        public delegate double M(double[] probkaWzorcowa, List<double> probkaTestowa);
        public List<double[]> wczytajzPliku(string sciazkaPliku)
        {
            string[] file = File.ReadAllLines(@sciazkaPliku);
            List<double[]> listaProbek = new List<double[]>();
            string[] tmp;

            string test = "1,1";
            double wynikTestu;
            bool przecinek = double.TryParse(test, out wynikTestu);
            //petla po wierszach
            foreach (string row in file)
            {
                //podzielenie wiersza na poszczegolne elementy                
                tmp = row.Trim().Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                double[] pom = new double[tmp.Length];
                for (int i = 0; i < tmp.Length; i++)
                {
                    //zmiana . na ,
                    if (przecinek)
                        tmp[i] = tmp[i].Replace(".", ",");
                    else
                        tmp[i] = tmp[i].Replace(",", ".");
                    pom[i] = double.Parse(tmp[i]);
                }
                listaProbek.Add(pom);
            }
            return listaProbek;
        }

        private double najwiekszyElement(List<double[]> lista, int indeks)
        {
            double max = double.MinValue;
            foreach (double[] element in lista)
            {
                if (max < element[indeks])
                {
                    max = element[indeks];
                }
            }
            return max;
        }

        private double najmniejszyElement(List<double[]> lista, int indeks)
        {
            double min = double.MaxValue;
            foreach (double[] element in lista)
            {
                if (min > element[indeks])
                {
                    min = element[indeks];
                }
            }
            return min;
        }

        private double norm(double v, double min, double max)
        {
            return (v - min) / (max - min);
        }

        public void normalizuj(List<double[]> lista)
        {
            for (int i = 0; i < lista[0].Length - 1; i++)
            {
                foreach (var element in lista)
                {
                    double min = najmniejszyElement(lista, i);
                    double max = najwiekszyElement(lista, i);
                    element[i] = norm(element[i], max, min);
                }
            }
        }

        //funkcja zwracająca liste klas wzorcowych
        public HashSet<double> listaKlasWzorcowych(List<double[]> lista)
        {
            HashSet<double> listaKlasProbkowych = new HashSet<double>();
            foreach (double[] d in lista)
                listaKlasProbkowych.Add(d[d.Length - 1]);


            return listaKlasProbkowych;
        }

        public Dictionary<double, double> utworzSlownikOdleglowciZParametru(HashSet<double> listaKlasProbkowych, Dictionary<double, List<double>> slownikOdleglosci, int parametr_k)
        {
            Dictionary<double, double> slownikOdleglowciZParametru = new Dictionary<double, double>();

            foreach (double key in listaKlasProbkowych)
            {
                double wartoscKlasyfikacji = 0;
                for (int i = 0; i < parametr_k; i++)
                {
                    wartoscKlasyfikacji += slownikOdleglosci[key][i];
                }
                slownikOdleglowciZParametru.Add(key, wartoscKlasyfikacji);
            }
            return slownikOdleglowciZParametru;
        }



        public double klasaZNajmniejszaOdlegloscia(Dictionary<double, double> slownikOdleglowciZParametrem)
        {
            double klasa = slownikOdleglowciZParametrem.Keys.First();
            double odleglosc = slownikOdleglowciZParametrem[klasa];
            foreach (KeyValuePair<double, double> u in slownikOdleglowciZParametrem)
            {
                if (u.Value < odleglosc && klasa != u.Key)
                {
                    klasa = u.Key;
                    odleglosc = u.Value;
                }
            }

            int ileRazy = 0;
            foreach (KeyValuePair<double, double> u in slownikOdleglowciZParametrem)
            {
                if (u.Value == odleglosc)
                    ileRazy++;
            }

            if (ileRazy != 1)
                klasa = 0.1;

            return klasa;
        }
    }
}
