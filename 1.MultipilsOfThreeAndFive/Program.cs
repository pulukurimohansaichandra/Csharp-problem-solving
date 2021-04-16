using System;

namespace _1.MultipilsOfThreeAndFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int multipilSum=NumberPassing();
            Console.WriteLine(multipilSum);

        }

        static int NumberPassing()
        {
            int multipleSum=0;
            for(int count=1;count<1000;count++)
            {
                  multipleSum+=MultipilsOfThreeAndFive(count);
            }

            return multipleSum;
        }

        static int MultipilsOfThreeAndFive(int number)
        {
            int result=0;
            if((number%3)==0)
            {
                result=number;
            }
            else if((number%5)==0)
            {
               result=number;
            }

            return result;
        }
    }
}
