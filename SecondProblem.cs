namespace Euler
{
  class SecondProblem
  {
    //BruteForce
    public static long BruteForce()
    {
      long fib1 = 1;
      long fib2 = 1;
      long result = 0;
      long sum = 0;

      while (result < 4000000)
      {
        if (result % 2 == 0)
        {
          sum += result;
        }
        result = fib1 + fib2;
        fib1 = fib2;
        fib2 = result;
      }

      return sum;
    }
    //EfficientSolution
    public static long CalculateOnlyEvenNumbers()
    {
      long fib6 = 0;
      long fib3 = 2;
      long result = 2; //Think of result is Fn and Fn = 4*Fn-3 + Fn-6 =>  Fn-3 = fib3 and Fn-6 = fib6
      long sum = 0;

      while (result < 4000000)
      {
        sum += result;
        result = 4 * fib3 + fib6;
        fib6 = fib3;
        fib3 = result;
      }
      return sum;
    }

  }
}
