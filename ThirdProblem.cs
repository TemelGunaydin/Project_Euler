using System;
using System.Diagnostics; //Used for measuring Elapsed time in ms
namespace Algos
{
  class ThirdProblem
  {
    static void Main(string[] args)
    {

      long largestFactor = 0;
      const long number = 600851475143;
      long[] factors = new long[2];

      var watch = Stopwatch.StartNew(); //Start time of the algorithm
      for (long i = 2; i * i < number; i++) //Only count up to square root of the original number
      {
        if (number % i == 0) //This if block find the factors of the numbers
        {
          factors[0] = i; //This is the first factor
          factors[1] = number / i; //This is the second factor. Because we are counting up to square root of the number, by dividing we are finding the second factor which is located after the square root of the number
          for (int k = 0; k < 2; k++) //This for loop used for checking factors[0] and factors[1]
          {
            bool isPrime = true;
            for (long j = 2; j * j < factors[k]; j++) //This for loop used for finding whether factor[0] 0r factor[1] is prime or not
            {
              if (factors[k] % j == 0)
              {
                isPrime = false;
                break;
              }
            }
            if (isPrime && factors[k] > largestFactor)
            {
              largestFactor = factors[k];
            }
          }

        }
      }
      watch.Stop();//End time of the algorithm

      System.Console.WriteLine($"Execution time is {watch.ElapsedMilliseconds}ms"); //Used for printing elapsed algorithm time
      System.Console.WriteLine(largestFactor); //Prints largest factor
    }

  }
}

