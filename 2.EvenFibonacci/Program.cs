using System;

namespace _2.EvenFibonacci
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int n1=1,n2=2,n3=0,sum=2;

           while(n3<4000000)
           {
              n3=n1+n2;
              n1=n2;
              n2=n3;
              if(n3%2==0)
              {
                  sum=sum+n3;
              }
           }

           Console.WriteLine(sum); 
           
        }
        

        
    }
}
