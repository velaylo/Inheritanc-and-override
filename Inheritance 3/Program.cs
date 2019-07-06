using System;
using System.Linq;
using System.Collections.Generic;

namespace Inheritance_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SymbArray symbArray = new SymbArray(new int[] { 1, 6, 3, 7, 4 }, new char[] {'a','s','d','f'});
            Console.WriteLine(symbArray.ToString());
            Console.ReadKey();
        }
    }


    class NumArray
    {
        public int[] numarray;

        public NumArray(int[] _array)
        {
            numarray = _array;
        }

        public override string ToString()
        {
            string txt="";
            foreach (int i in numarray)
            {
                Convert.ToString(i);
                txt += i;
            }         
            return txt ;
        }
    }

    class SymbArray:NumArray
    {
        public char[] symbArray;

        public SymbArray(int[] numArray, char[] symbArray) : base(numArray)
        {
            this.symbArray = symbArray;
        }

        public override string ToString()
        {
            string firstTxt = "";
            foreach (int i in numarray)
            {
                Convert.ToString(i);
                firstTxt += i;
            }
            string secondtTxt="";
            foreach (char i in symbArray)
            {
                Convert.ToString(i);
                secondtTxt += i;
            }
            string summaryText=(firstTxt+"   "+secondtTxt);

            return summaryText;
        }
    }

}
