internal class Program
{
    private static void Main(string[] args)
    { 
        Random rnd= new Random();
        int comp_num = rnd.Next(1,100);
        int tien = 1000;
        int solanchoi = 0;
        Console.WriteLine("Ban hien co " + tien);
       // do
       // {
            for (int i = 0; i < 5; i++, solanchoi++)
            {

                Console.WriteLine("Enter your number:");
                int man_num = Convert.ToInt32(Console.ReadLine());
                if (man_num == comp_num) { Console.WriteLine("Ban doan dung roi!"); break; }
                else
                {
                    Console.WriteLine("That tiec, ban doan sai roi");
                    if (i == 4) continue;
                    if (man_num < comp_num) { Console.WriteLine("Goi y: So ban doan nho hon so may "); }
                    else
                    { Console.WriteLine("Goi y: So ban doan lon hon so may "); }

                }

            }
            Console.WriteLine("Computer number:" + comp_num);
            Console.WriteLine("Ban muon choi khong: Co/Khong");
            string res = Console.ReadLine();
            if (res.ToUpper().Equals("Khong"))
            {
                Console.WriteLine("solanchoi:" + solanchoi);
                Console.WriteLine("Hen gap lai!");
                
            }
      //  }
      //  while (false);

    }
}