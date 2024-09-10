using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace baithfuction;

class Program
{
   /* static void Main(string[] args)
    {
        int x = 10;
        int y = 5;
        int sum = Add(x,y);
        Console.WriteLine($"sum cua x va y: {sum}");
    }
    static int Add(int a, int b)
    {int sum = a + b;
    return sum;
    }    
   */
   /*static void Main (string[] args)
  {    
    int a= max(1);
    int m = max(1,2);
    Console.WriteLine(m);
  }
static int max(int a, params int[] args)
    {
        if (args.Length == 0)
            return a;

        int m = args[0];
        foreach (int i in args)
        {
            if (i > m)
                m = i;
        }
        return Math.Max(a, m);
    }
    */
  static int Sum (params int [] pars)
{
    int sum = 0;
    foreach (int i in pars)
    sum += i;
    return sum;
}
static void Main (string [] args)
{
    int x = Sum (1,2,3,4);
    int y = Sum (1);
    int z = Sum (1,2,3,4,5,6,7,8);
    Console.Write ($" x= {x}, y={y}, z={z}");
    
}
}
