using System;

class Program
{
    static void Main()
    {
        int N = 5;
        int count = N * 2 - 1;

        for (int i = 1; i <= count; i++)
        {
            for (int j = 1; j <= count; j++)
            {
                if (j == i || (j == count - i + 1))
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
         Console.WriteLine("Created By Narendra");
        Console.WriteLine("MCA II A ||  Roll.no:57");
        
    }
}
