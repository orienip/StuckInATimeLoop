using System;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 100");            
            
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 1 && N <= 100)
            {
                int i = 1;
                while (i <= N)
                {
                    string note = i.ToString() + " Abracadabra";
                    Console.WriteLine(note);
                    i++;
                }

            }

        }
    }
}
