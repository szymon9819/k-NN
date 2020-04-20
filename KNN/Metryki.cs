using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN
{
    class Metryki
    {
        public static int parametr_M=2;
        public static double metrykaEuklidesowa(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += (probkaTestowa[i] - probkaWzorcowa[i]) * (probkaTestowa[i] - probkaWzorcowa[i]);
            }
            return Math.Sqrt(suma);
        }


        public static double metrykaCzebyszewa(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                if (suma < probkaTestowa[i] - probkaWzorcowa[i])
                    suma = Math.Abs(probkaTestowa[i] - probkaWzorcowa[i]);
            }
            return suma;
        }


        public static double metrykaLogarytmem(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += Math.Abs( Math.Log10(probkaTestowa[i]) - Math.Log10(probkaWzorcowa[i]));
            }
            return Math.Sqrt(suma);
        }


        public static double metrykaManhattan(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += Math.Abs(probkaTestowa[i] - probkaWzorcowa[i]);
            }
            return suma;
        }


        public static double metrykaMinkowskiego(double[] probkaWzorcowa, List<double> probkaTestowa)
        {          
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += Math.Abs( Math.Pow( (probkaTestowa[i] - probkaWzorcowa[i]), parametr_M));
            }
            return Math.Pow(suma,1/ parametr_M);
        }
    }
}
