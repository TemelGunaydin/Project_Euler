
namespace Euler
{
  /*
   First Problem: 
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.

   Project Euler Web Site => https://projecteuler.net/problem=1
   Solution Address       => https://www.mathblog.dk/project-euler-problem-1/
  */

  class FirstProblem
  {
    //BruteForce - O(n)
    public static int Solution()
    {
      int result = 0;
      for (int i = 1; i < 1000; i++)
      {
        if (((i % 3) == 0) || ((i % 5) == 0))
        {
          result += i;
        }
      }
      return result;
    }

    //EfficientSolution - O(1)
    public static int Solution2(int n, int p)
    {
      return n * (p / n) * ((p / n) + 1) / 2;
    }
  }
}
