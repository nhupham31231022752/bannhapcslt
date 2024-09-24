using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;

namespace baithjaggedarray;

class Program
{
    static void Main(string[] args)
    {  /*int [][]a= new int [4][]{
    new int [] {1,1,1,1,1},
    new int [] {2,2},
    new int [] {3,3,3,3},
    new int [] {4,4}
    
        };
    JaggedArray(a);*/
    
    /*Console.Write("Enter the number of row:");
    int rows = Convert.ToInt32(Console.ReadLine());
    int [][]a = new int [rows][];
    InputRandomArray(a,rows);
    PrintArray(a);*/
    //BiggestEachRow(a);
    /*SortAscendingRow(a);
    PrintArray(a);*/
    //PrintPrimes(a);

    /*Console.Write("Nhap vao so can tim: ");
       int val = Convert.ToInt32(Console.ReadLine());
    SearchAndPrintNu(a,val);*/
    //sort_rows(a);
    //PrintArray(a);
  /*Console.Write("Enter the number of row:");
    int rows = Convert.ToInt32(Console.ReadLine());
    int [][]a = new int [rows][];
  InputFromUser(a,rows);
  PrintArray(a);
  Console.WriteLine();
  sort_rows(a);
    Console.WriteLine();
  PrintArray(a);*/
  /*Console.Write("Enter the number of row:");
    int rows = Convert.ToInt32(Console.ReadLine());
    int [][]a = new int [rows][];
  InputFromUser(a,rows);
  PrintArray(a);
  Console.WriteLine();
  BiggestRow_1(a);*/
   Console.Write("Enter the no rows: ");
            int rows = int.Parse(Console.ReadLine());
            int[][] a = new int[rows][];
            InputRandomArray(a, rows);

            while (true)
            {
                int sel = menu();
                switch (sel)
                {
                    case 0: Console.WriteLine("Bye"); return;
                    case 1: InputRandomArray(a, rows); break;
                    case 2: PrintArray(a); break;
                    case 3: sort_rows(a); break;
                    case 4: PrintPrimes(a); break;
                    case 5:
                        Console.Write("Enter a number for searching: ");
                        int number = int.Parse(Console.ReadLine());
                        SearchAndPrintNu(a, number);
                        break;
                }
                        //...
                }
        
    } 
    static void JaggedArray (int [][]a)
    {
      for (int i=0; i<a.Length;i++) 
      { Console.Write ($"Row {i}: ");
        for (int j=0;j<a[i].Length;j++)
        {
            Console.Write (a[i][j]+ " ");
        }
        Console.WriteLine();
      } 
     
      }
      static void InputRandomArray(int[][]a,int rows)
      {  Random rnd = new Random();
        //Console.Write("Enter the number of row:");
        //int rows = Convert.ToInt32(Console.ReadLine());
        for (int i=0; i<rows;i++)
        {  Console.Write($"Enter the number of column 1th:");
        int cols = Convert.ToInt32(Console.ReadLine());
        a[i]= new int [cols];
          for(int j=0;j<cols;j++)
          {
            a[i][j]= rnd.Next(50);
          }
        }

      }
      static void PrintArray(int[][]a)
      {
        for(int i =0; i<a.Length;i++)
        {
          for(int j=0; j<a[i].Length;j++)
          {Console.Write (a[i][j] + " ");}
          Console.WriteLine();
        }
      }
      static void InputFromUser(int[][]a,int rows)
      { 
        for(int i=0; i<rows;i++)
        {
          Console.Write($"Enter column numbers row {i}th:");
          int cols = Convert.ToInt32(Console.ReadLine());
          a[i]= new int [cols];
          for(int j=0;j<cols;j++)
          { 
            bool res =int.TryParse(Console.ReadLine(),out a[i][j]);
            if(!res){Console.WriteLine("Incorrect number. Enter again");
            j--;}
            }
          }
          Console.WriteLine();
        }
      
      static void BiggestEachRow(int[][]a)
      {int max=0;
      int j=0;
        for (int i=0; i<a.Length;i++)
        { 
          for ( j=0;j<a[i].Length-1;j++)
          {   max = a[i][j];
            if(a[i][j]< a[i][j+1]){max= a[i][j+1];}
          
          }
          Console.WriteLine($"max row {i}: {max}");
        }
      }
      static void BiggestArray (int[]a)
      {  int max=0;
         for (int i=0; i<a.Length;i++)
      {  int index = i;
        for(int j=i+1;j<a.Length;j++)
        { max= a[index];
          if(a[j]>a[index])
          {
          max=a[j];}
        }
        
      }
      Console.WriteLine($"max: {max}");
       
     }
     static void BiggestRow_1(int[][]a)
     {
      for (int i = 0; i < a.Length; i++)
                BiggestArray(a[i]);
               
     }
       
      static void SortAscendingRow (int[][]a)
      {
        for (int i=0; i<a.Length;i++)
        { for(int index =0; index<a[i].Length;index++)
          {for (int j=0; j<a[i].Length-1;j++)
          {
              if(a[i][j]>a[i][j+1])
              {
                int temp= a[i][j];
                a[i][j]=a[i][j+1];
                a[i][j+1]=temp;
              }
          } }
          Console.WriteLine();
        }
      }
      static bool IsPrime(int num)
      {
        for(int i=2; i<=num/2;i++)
        {if(num%i==0) {return false;}
        }
        return true;
      }
      static void PrintPrimes(int[][]a)
      {
        for (int i=0; i<a.Length;i++)
        {
          for(int j=0; j<a[i].Length;j++)
          {
            if(IsPrime(a[i][j]))
            {
              Console.WriteLine($"{a[i][j]} xuat hien tai a[{i}][{j}]");
            }
          }
        }
      }
      static void SearchAndPrintNu (int[][]a,int val)
      { 
       for(int i =0; i<a.Length;i++)
        {
          for(int j=0; j<a[i].Length;j++)
          {
            if(a[i][j]==val) 
            {
                Console.WriteLine($"tim thay o vi tri a[{i}][{j}]");
            }
          }
      }
    }
     static void sort_array(int[] a)
        {
            for(int i = 0;i < a.Length;i++)
                for (int j = 0;j<a.Length-1;j++)
                    if (a[j+1] < a[j])
                    {
                        int temp = a[j]; 
                        a[j] = a[j+1];
                        a[j+1] = temp;
                        Console.WriteLine (a[j]);
                        Console.WriteLine(a[j+1]);
                     }
              Console.WriteLine();
        }

        static void sort_rows(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
                sort_array(a[i]);
        }
  static int menu()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("\t\tjagged array demo\n");
            //Console.WriteLine("1. Jagged array init");
            Console.WriteLine("2. print array");
            Console.WriteLine("3. Sort rows..");
            Console.WriteLine("4. Print Primes");
            Console.WriteLine("5. Search and print...");
            Console.WriteLine("6....");
            Console.WriteLine("0. exit");
            Console.WriteLine();
            Console.Write("Your select <1..6>");
            int sel = 0;
            while (true)
            {
                bool c = int.TryParse(Console.ReadLine(), out sel);
                if (c && sel >= 0 && sel <= 6)
                    break;
                else Console.WriteLine("Please enter a valid choice!");
            }
            return sel;
       
            
        }
    }

            


