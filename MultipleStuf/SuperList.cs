using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace MultipleStuf
{
    public class SuperList : List<double>
    {


        // Constructor classe herda uma lista de doubles
        public SuperList() : base() {} 

        // 
        public void GetMinMax1(out double min, out double max)
        {

            min = this[0]; // 7
            max = this[0]; // 7
            
            foreach(double number in this)
            {
                if(number < min) // 5,  //min = 7
                {
                    min = number;
                }

                else if(number > max) // max = 7
                {
                    max = number;
                }
            }
        }

        public void GetMinMax2()
        {
            MinMax minMax = new MinMax();

            double min = this[0]; 
            double max = this[0];


            foreach(double number in this)
            {
                if(number < min) // 5,  //min = 7
                {
                    minMax.min = number;
                }

                else if(number > max) // max = 7
                {
                    minMax.max = number;
                }
            }

            Console.WriteLine(minMax.min + minMax.max);
        }

        public class MinMax
        {
            public double min = 0;
            public double max = 0;

        }

        public Tuple<double, double> GetMinMax3()
        {

            
            double min = this[0]; // 7
            double max = this[0]; // 7
            
            foreach(double number in this)
            {
                if(number < min) // 5,  //min = 7
                {
                    min = number;
                }

                else if(number > max) // max = 7
                {
                    max = number;
                }
            }

            // returning ref type values
            return new Tuple<double, double> (min, max);
        }

        public (double Min, double Max) GetMinMax4()
        {

            double min = this[0]; // 7
            double max = this[0]; // 7
            
            foreach(double number in this)
            {
                if(number < min) // 5,  //min = 7
                {
                    min = number;
                }

                else if(number > max) // max = 7
                {
                    max = number;
                }
            }
            return (min, max);
        }

      
    }
}