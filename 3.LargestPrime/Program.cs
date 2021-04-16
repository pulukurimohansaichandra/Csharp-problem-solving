using System;

namespace _3.LargestPrime
{
    class Program
    {
         const long numm=600851475143;
        static long largestFact = 0;
        static void Main(string[] args)
        {
            for (long i = 2; i < numm; i++) {
             if (numm % i == 0) { // It is a divisor
             bool isPrime = true;
              for (long j = 2; j < i; j++) {
              if (i % j == 0) {
                isPrime = false;
                break;
                 }
        }
        if (isPrime) {
            largestFact = i;
        }
    

           
           Console.WriteLine(largestFact);
        }
    }
}
}
}
