using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculations
	{
        private string language;
        private double a;
        private double b;

        public Calculations(double a_fs, double b_fs)
        {
            this.a = a_fs;
            this.b = b_fs;
        }
        public Calculations(double a)
        {
            this.a = a;
        }
        public double Summary()
        {
            double sum = a + b;
            return sum;
        }
        public double Difference()
        {
            double diff = a - b;
            return diff;
        }
        public double Division()
        {
            double div = a / b;
            return div;
        }
        public double Multiply()
        {
            double multi = a * b;
            return multi;
        }
        public double Sin()
        {
            double result = Math.Sin((a * (Math.PI)) / 180);
            return result;
        }
        public double Cos()
        {
            double result = Math.Cos((a * (Math.PI)) / 180);
            return result;
        }
        public string Language
        {
            get { return language; }
            set
            {
                language = value;
                // OnPropertyChanged("Language");
            }
        }
    }
}
