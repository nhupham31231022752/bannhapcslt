internal class Program
{
    private static void Main(string[] args)
    {
        /* int[][] a = new int[4][] {
             new int[] {1,1,1,1,1 },
             new int[] { 2, 2 },
             new int[] { 3, 3, 3, 3 },
             new int[] { 4, 4 }
         };
         JaggedArraay(a);*/

        Console.Write("ENter the no rows: ");
        int rows = int.Parse(Console.ReadLine());
        int[][] a = new int[rows][];
        InputArrayRandom(a,rows);
        print(a);
        Console.WriteLine();
        Biggest(a);
        
       




    }
    static void JaggedArraay(int[][] a)
    {

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($" Row {i}: ");
            for (int j = 0; j < a[i].Length; j++)
            { Console.Write(a[i][j] + " "); }
            Console.WriteLine();
        }
      
    }
    static void InputArrayRandom(int[][]a,int rows)
    {

        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Enter the No columns of the row {i}th: ");
            int cols = int.Parse(Console.ReadLine());
            a[i] = new int[cols];
            for (int j = 0; j < cols; j++)
                a[i][j] = rnd.Next(10, 50);
        }


    }
    static void print(int[][] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
                Console.Write(a[i][j] + "\t");
            Console.WriteLine();
        }
    }
    static void Biggest(int[][] a)
    {
        int j = 0;
        int max = a[0][0];
        for (int i = 0; i < a.Length; i++)
        {
            for ( j = 0; j < a[i].Length-1; j++)

            {   
                if (a[i][j] < a[i][j + 1]) { max = a[i][j + 1]; }
               
            }

            Console.WriteLine($" max{i}{j}:{max}");
        }
    }
}