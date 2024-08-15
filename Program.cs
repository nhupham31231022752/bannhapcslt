using System.Dynamic;

namespace baitap1;

class Program
{    static void Main(string[] args)
    {
        //cau_01 ();
        // cau_02();
    }
    static void cau_01()
     {int a;
     int b;
     Console.WriteLine(" Nhap vao so a :");
     a = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Nhap vao so b :");
     b = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Tong hai so a va b:");
     Console.WriteLine("{0} + {1} = {2}",a,b,a+b); }
       static void cau_02()
       { int a = 5;
         int b = 10;
        Console.WriteLine("Before Swap a = "+a+ "b = "+b);
        b = b-a;
        a = a+b;
        Console.WriteLine("Before Swap a = "+a+ "b = "+b);
       }
     static void cau_03()
     {}
}
 