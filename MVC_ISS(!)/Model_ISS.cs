using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ISS___
{
    class Model_ISS
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }
        public double L1 { get; set; }
        public double L2 { get; set; }
        static double Obj_coordinat(double X, double Y, out double X1, out double Y1, out double X4, out double Y4)
        {
            X1 = X - 10;
            Y1 = Y + 10;
            X4 = X + 10;
            Y4 = Y - 10;
        }
        public double Distance_to_aster(double X1,double Y1,double X6, double Y6, out double L1,out double L2)
        {
            L1 = (Math.Sqrt(Math.Pow(X6-X,2) + Math.Pow(Y6-Y,2))-7);
            L2 = (Math.Sqrt(Math.Pow(X6-X,2) + Math.Pow(Y6 - Y, 2))-7);
        }
    }
}
