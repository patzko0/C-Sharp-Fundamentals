using System;


namespace PrintingNums
{
    class printNums
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i+=1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
