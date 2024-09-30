using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace luyentap;

class Program
{  static void Main (string []args)
{
    //int []a= new int [3];
    
    //InputRandomData(a);
    //InputDataFromUser(a);
   // PrintArray(a);

    /*int [,]b= new int [3,4];
    InputRandomData_2(b);
    InputDataFromUser_2(b);
    PrintArray_2(b);*/

   /* Console.WriteLine("nhap vao so dong:");
    int rows = Convert.ToInt16(Console.ReadLine());
    int[][]c = new int [rows][];
    //InputFromUser_Jagged(c,rows);
    InputRandomData_3(c,rows);
    PrintArray_Jagged(c);
    Console.WriteLine();
    SortEachRow(c);
    PrintArray_Jagged(c);
    //PrintPrime(c);
    /*BiggestRow(c);
    Console.WriteLine();
     BiggestArrays(c);
      int max = BiggestArrays(c);
        // Hiển thị kết quả
        Console.WriteLine("So lon nhat trong mang là: " + max);*/

    string s = Console.ReadLine();
    PrintArray(s);
    //Separate(s);
    //Reverse(s);
    CountAlDiSep(s);
}  
#region 
    /// <summary>
    /// Luyen tap mang 1 chieu
    /// </summary>
    /// <param name="a"></param>
  static void InputRandomData(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100);
            }
    
        }
    static void InputDataFromUser(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Please enter a number:");

                bool res = int.TryParse(Console.ReadLine(), out a[i]);
                if (!res)
                {
                    Console.WriteLine("Incorect number. Enter again");
                    i--;
                }
            }
        }
         static void PrintArray(int[] a)
        {
            foreach (int i in a)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
        }
        # endregion
        #region 
        /// <summary>
        /// Luyentapmang2
        /// </summary>
        /// <param name="b"></param>
        static void InputRandomData_2(int[,]b)
        {
            Random r = new Random();
            
            for (int i=0; i<b.GetLength(0);i++)
            {
             for (int j=0; j<b.GetLength(1);j++)
             { b[i,j]= r.Next(50);
                Console.Write (b[i,j]+" ");
             }
             Console.WriteLine() ;
           }
        }
        static void InputDataFromUser_2(int [,]b)
        {
            for (int i=0; i<b.GetLength(0);i++)
            {
             for (int j=0; j<b.GetLength(1);j++)
             {  bool res = int.TryParse(Console.ReadLine(),out b[i,j]);
              if (!res)
                {
                    Console.WriteLine("Incorect number. Enter again");
                    j--;
                }
                
             }
            
           }
        }
        static void PrintArray_2(int[,]b)
        {
            for (int i=0; i<b.GetLength(0);i++)
            {
                for (int j =0; j<b.GetLength(1);j++)
                {
                    Console.Write (b[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
        #endregion
         /// <summary>
         /// luyentapmangjagged
         /// </summary>
         /// <param name=""></param>
         static void InputFromUser_Jagged(int[][]c, int rows)
         {
            for (int i=0; i<rows;i++)
                { Console.WriteLine($"Nhap vao so cot cua row{i}");
                    int cols = Convert.ToInt16(Console.ReadLine());
                c[i]= new int [cols];
                for (int j =0; j<cols;j++)
                {
                   bool res = int.TryParse(Console.ReadLine(), out c[i][j]);
                    if (!res)
                {
                    Console.WriteLine("Incorect number. Enter again");
                    j--;
                }
                }
            }
         }
         static void PrintArray_Jagged(int[][]c)
         {
            for(int i=0; i<c.Length;i++)
            { Console.Write($"Row {i}: ");
                for(int j =0; j<c[i].Length;j++)
                {
                    Console.Write(c[i][j]+ " ");
                }
                Console.WriteLine();
            }
         }
          static void InputRandomData_3(int[][] c, int rows)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the No columns of the row {i}th: ");
                int cols = int.Parse(Console.ReadLine());
                c[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                    c[i][j] =rnd.Next(10, 50);
            }
        }
 static void BiggestArray (int[]a)
      {  int max = a[0];
         for (int i=1; i<a.Length;i++)
      {   
        if(a[i]>max){max=a[i];}
      }
      Console.WriteLine($"max: {max}");
       
     }
     static void BiggestRow(int[][]a)
     {
      for (int i = 0; i < a.Length; i++)
                BiggestArray(a[i]);
               
     }
     static int BiggestArrays(int[][]a)
     { int max=a[0][0];
       foreach (int[] subArray in a)
        {
            // Duyệt qua từng phần tử trong mảng con
            foreach (int num in subArray)
            {
                if (num > max)
                {
                    max = num; // Cập nhật giá trị lớn nhất
                }
            }
        }

        return max;
     }
     
     static bool isPrime(int num)
    {
      for(int i=2; i<num/2;i++)
      {
        if(num%2==0)
        {return false;}
      }
        return true;
    }
     static void PrintPrime(int [][]c)
     {
        for(int i=0; i<c.Length;i++)
        {
            for (int j=0; j<c[i].Length;j++)
            {
                if(isPrime(c[i][j]))
                {
                    Console.WriteLine($"{c[i][j]} xuat hien dong {i} va cot{j}");
                }
            }
        }
     }
     static void SortEachRow(int[][]c)
     { 
        for(int i=0; i<c.Length;i++)
        {  for(int z=0; z<c[i].Length;z++)
            for (int j=0; j<c[i].Length-1;j++)
            { 
                if(c[i][j]>c[i][j+1])
                {
                    int temp = c[i][j];
                    c[i][j]= c[i][j+1];
                    c[i][j+1]=temp;
                }
            } 
        }
    }
    /// <summary>
    /// luyentapstring
    /// </summary>
    static void PrintArray(string s)
    {   int c= s.Length;
        Console.WriteLine(c);
        Console.WriteLine(s);
    }
    static void Separate(string s)
    {
        foreach(char c in s )
        {Console.WriteLine(c+ " ");}

    }
    static void Reverse(string s)
    {
        for(int i=s.Length-1; i>=0;i--)
        {  
            Console.Write(s[i]);
        }
    }
    static void CountAlDiSep (string s)
    {int alapha = 0; int digit=0; int special=0;
        foreach(char c in s)
        { 
            if((c>='a'|| c>='A') && (c<='z'|| c<='z' ))
            {
                alapha +=1;
            }
            else if(c>= '0' && c<='9')
            {
                digit+=1;
            }
            else { special+= 1;  }
        }
        Console.WriteLine(alapha);
        Console.WriteLine(digit);
        Console.WriteLine(special);

    }
}

        