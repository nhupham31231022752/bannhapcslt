using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" Nhap vao string:");
        string s = Convert.ToString(Console.ReadLine());
        Console.WriteLine(s);
        PrintString(s);
        LengthString(s);
        Reverse_Separate(s);
        NuWords(s);
        string a = "     to count the total number of words in string    ";
        test(a);
    }
    static void PrintString(string s)
    {
        Console.WriteLine(s.Length);
        Console.WriteLine(s);

    }
    static void LengthString(string s)
    {
        int length = 0;
        foreach (char c in s)
        {
            length += 1;
        }
        Console.WriteLine($"Do dai cua string {length}");
    }
    static void Reverse_Separate(string s)
    {
        string se = "";
        string re = "";
        foreach (char c in s)
        {
            re = c + " " + $"{re}";
            se = $"{se}"+c+" ";
        }
        Console.WriteLine(se);
        Console.WriteLine(re);
    }
    static void NuWords(string s)
    { int count = 0;
        foreach (char c in s)
        {
            if (c == ' ') {count++;}
        }
        int numword = count + 1;
        Console.WriteLine(numword);
    }
    static void NuWords_1(string a)
    {

    }
    static void test (string s)
    {
        foreach (int c in s)
        {
            Console.WriteLine(c);
        }   
    }
}