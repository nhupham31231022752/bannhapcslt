using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
       Console.Write("Nhap vao so N:");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[N];
        InputRandomData(a);
        PrintArray(a);
        FindResult(a);
        PrintPrime(a);
        Console.WriteLine();
        Sort(a);
        PrintArray(a);

        Console.Write("Nhap vao M:");
        int d= Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap vao N:");
        int e= Convert.ToInt32(Console.ReadLine());
        int[,]b= new int[d,e];
        InputRandomData_1(b);
        PrintArray_1(b);
        Sum(b, ref e);
        while (true)
        { int sel = menu(); 
            switch (sel)
            {
                case 0: Console.WriteLine("Bye"); return;
                    case 1: InputRandomData(a); break;
                    case 2: PrintArray(a);break;
                    case 3: FindResult(a); break;
                    case 4: PrintPrime(a);break;
                    case 5: Sort(a); break;




            }    
        }
    }
    static void InputRandomData(int[] a)
    {
        Random rnd = new Random();
        for (int i = 0; i < a.Length; i++)
        { a[i] = rnd.Next(50); }
    }
    static void PrintArray(int[] a)
    {
        foreach (int i in a)
        { Console.WriteLine($"{i}"); }
    }
    static int FindValue(int[] a, int x)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
            { return i; }
        }
        return -1;
    }
    static void FindResult(int[] a)
    {
        Console.Write("Nhap vao so can tim:");
        int x = Convert.ToInt32(Console.ReadLine());
        int res= FindValue(a, x);
        if (res == -1) { Console.WriteLine(res); }
        else { Console.WriteLine($"x xuat hien tai vi tri {res}"); }
    }
    static bool isPrime(int num)
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % 2 == 0) { return false; }
        }
        return true;
    }
    static void PrintPrime(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (isPrime(a[i]))
            {
                Console.WriteLine(" so nguyen to trong mang");
                Console.WriteLine(a[i]);
            }
        }
    }
    static void Sort(int[]a)
    {
        for (int i = 0; i < a.Length; i++)
        { for(int j=0; j<a.Length-1; j++)
                if (a[j] < a[j+1])
                {
                    int temp = a[j];
                    a[j] = a[j+1];
                    a[j+1] = temp;
                }   
        }
    }
    static void InputRandomData_1(int[,] b)
    {
        Random r = new Random();
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[i, j] = r.Next(50);

            }
        }
    }
    static void PrintArray_1(int[,] b)
    {
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                Console.Write(b[i, j] + "\t ");
            }
            Console.WriteLine();
        }

    }
    static void Sum(int[,] b, ref int e)
    {
        Console.WriteLine("Nhap vao cot can tinh tong");
           int col=Convert.ToInt32(Console.ReadLine());
        for(int i = col;i<=e;i++)
        {
            for(int j= col; j <= col;) { }
        }    
    }
    static int menu()
    {
        Console.WriteLine("\n ==============");
        Console.WriteLine("1.Mang mot chieu ngau nhien");
        Console.WriteLine("2.In mang mot chieu");
        Console.WriteLine("3.Tim mot so trong mang 1 chieu");
        Console.WriteLine("4.In cac phan tu la so nguyen to");
        Console.WriteLine("5.Kta mot bang duoc sap xep");
        Console.WriteLine("6.Sap xap mang giam dan");
        Console.WriteLine("7.Mang 2 chieu ngau nhien");
        Console.WriteLine("8.In mang 2 chieu");
        Console.WriteLine("9.Tong mot cot");
        int sel = 0;
        while(true) 
        { bool c= int.TryParse(Console.ReadLine(), out sel);
            if (c && sel >= 0 && sel <= 6) break;
            else
            {
                Console.WriteLine("Nhap lua chon hop le:");
                return sel;
            }
        }
    }


}
    
