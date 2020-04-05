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

        public List<double[]> wczytajzPliku(string sciazkaPliku)
        {
            string[] file = File.ReadAllLines(@sciazkaPliku);
            List<double[]> listaProbek = new List<double[]>();
            string[] tmp;
            //petla po wierszach
            foreach (string row in file)
            {
                //podzielenie wiersza na poszczegolne elementy
                tmp = row.Split('\t');
                double[] pom = new double[tmp.Length];
                for (int i = 0; i < tmp.Length; i++)
                {
                    //zmiana . na ,
                    tmp[i] = tmp[i].Replace(".", ",");
                    pom[i] = double.Parse(tmp[i]);
                }
                listaProbek.Add(pom);
            }
            return listaProbek;
        }


        //funkcja zwracająca liste klas wzorcowych
        public HashSet<double> listaKlasWzorcowych(List<double[]> lista)
        {
            HashSet<double> listaKlasProbkowych = new HashSet<double>();
            foreach (double[] d in lista)
            {
                listaKlasProbkowych.Add((d[d.Length - 1]));
            }
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

        public List<double> wyznaczKlaseProbki(List<double[]> listaWzorcowa, List<double> probkaTestowa, Dictionary<double, double> slownikOdleglowciZParametru)
        {
            double[] minimalnaWartosc = new double[] { 10000, 10000 };


            foreach (KeyValuePair<double, double> u in slownikOdleglowciZParametru)
            {
                if (minimalnaWartosc[1] > u.Value)
                {
                    minimalnaWartosc[0] = u.Key;
                    minimalnaWartosc[1] = u.Value;
                    Console.WriteLine("minWartosc: " + minimalnaWartosc[1] + " " + minimalnaWartosc[0]);
                }
            }
            probkaTestowa.Add(minimalnaWartosc[0]);

            return probkaTestowa;
        }

        public bool czyTakieSameWartosci(Dictionary<double, double> slownikOdleglowciZParametrem)
        {
            HashSet<double> pom = new HashSet<double>();
            foreach (KeyValuePair<double, double> u in slownikOdleglowciZParametrem)
            {
                pom.Add(u.Value);                
            }

            if (slownikOdleglowciZParametrem.Count == pom.Count)
                return false;
            return true;
        }

    }
}
