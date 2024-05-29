using System;
using System.Collections.Generic;


namespace MultipleStuf
{
    public class SuperList : List<double>
    {


        // Constructor classe herda uma lista de doubles
        public SuperList() : base() 
        {
        } 

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

        public class GetMinMax2
        {
            /*
            double min = 0, max = 0;

            public GetMinMax2(SuperList doubles)
            {

            }


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
            */

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

        public  GetMinMax4()
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

        }



    }
}