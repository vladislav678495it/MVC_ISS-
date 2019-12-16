using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ISS___
{
    class Model_asteroid
    {
        public double X5 { get; set; }
        public double Y5 { get; set; }
        public double X6 { get; set; }
        public double Y6 { get; set; }
        public double X7 { get; set; }
        public double Y7 { get; set; }
        public double X8 { get; set; }
        public double Y8 { get; set; }
        static double Obj_asteroid1(double X, double Y, out double X5, out double Y5, out double X6, out double Y6)
        {
            X5 = 400;
            Y5 = 400;
            X6 = 410;
            Y6 = 390;
        }
        static double Obj_asteroid2(double X, double Y, out double X7, out double Y7, out double X8, out double Y8)
        {
            X7 = 100;
            Y7 = 100;
            X8 = 110;
            Y8 = 90;
        }
    }
}
}
