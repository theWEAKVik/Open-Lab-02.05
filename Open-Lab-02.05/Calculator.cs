using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_02._05
{
    public class Calculator
    {
        public bool DivisibleByFive(int number)
        {

            if (number % 5 == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
    
}
