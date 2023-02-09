using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for( i = 1; i <= 300; i++)
            {
                if((i % 5) ==0 )
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

