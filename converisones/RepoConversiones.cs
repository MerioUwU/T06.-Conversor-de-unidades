using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converisones
{
    public class RepoConversiones
    {
        public double Convertir(double cm)
        {
            double result = cm / 100;
            return result;
        }
        public double Convertir(double m, double inches)
        {
            double result = m * inches;
            return result;
        }
        public double Convertir(double L, double a,double b)
        {
            double result = L * a * b;
            return result;
        }
    }
}
