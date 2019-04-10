using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double r;
        private double g;
        private double b;


        public Pixel(double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public double R
        {
            get { return r; }
            set { r = Chack(value); }
        }

        public double G
        {
            get { return g; }
            set { g = Chack(value); }
        }

        public double B
        {
            get { return b; }
            set { b = Chack(value); }
        }

        private double Chack(double val)
        {
            if (val > 1 || val < 0)
                throw new ArgumentException();
            return val;
        }

        public static double Trim(double val)
        {
            if (val < 0) return 0;
            if (val > 1) return 1;
            return val;
        }

        public static  Pixel operator *(Pixel p, double k)
        {
            return new Pixel(Pixel.Trim(p.R * k), Pixel.Trim(p.G * k), Pixel.Trim(p.B * k));
        }

        public static Pixel operator *(double k, Pixel p)
        {
            return p*k;
        }
    }
}
