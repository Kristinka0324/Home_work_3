using System;

namespace _3_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hallo!";
            s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
