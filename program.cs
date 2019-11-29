using System;

namespace prime
{
  public class GFG
  {
    public static void primeFactors(int num)
    {
        while (num % 2 == 0)
        {
            Console.Write(2 + " ");
            num /= 2;
        }
          for (int i = 3; i <= Math.Sqrt(num); i+= 2)
          {
              while (num % i == 0)
              {
                  Console.Write(i + " ");
                  num /= i;
              }
          }
        if (num > 2)
            Console.Write(num);
    }
    public static void Main()
    {
        int num = 100;
        primeFactors(num);
    }

  }
}
