using System;
using System.Collections.Generic;


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

        }

        public void GetMinMax3()
        {

        }

        public void GetMinMax4()
        {

        }



    }
}