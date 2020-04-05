using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN
{
    class Metryki
    {
        public double metrykaEuklidesowa(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += (probkaTestowa[i] - probkaWzorcowa[i]) * (probkaTestowa[i] - probkaWzorcowa[i]);
            }
            return Math.Sqrt(suma);
        }


        public double metrykaCzebyszewa(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                if (suma < probkaTestowa[i] - probkaWzorcowa[i])
                    suma = Math.Abs(probkaTestowa[i] - probkaWzorcowa[i]);
            }
            return suma;
        }


        public double metrykaLogarytmem(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += Math.Abs( Math.Log10(probkaTestowa[i]) - Math.Log10(probkaWzorcowa[i]));
            }
            return Math.Sqrt(suma);
        }


        public double metrykaManhattan(double[] probkaWzorcowa, List<double> probkaTestowa)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += Math.Abs(probkaTestowa[i] - probkaWzorcowa[i]);
            }
            return suma;
        }


        public double metrykaMinkowskiego(double[] probkaWzorcowa, List<double> probkaTestowa, double p)
        {
            double suma = 0;
            for (int i = 0; i < probkaTestowa.Count; i++)
            {
                suma += Math.Abs( Math.Pow( (probkaTestowa[i] - probkaWzorcowa[i]),p));
            }
            return Math.Pow(suma,1/p);
        }
    }
}
