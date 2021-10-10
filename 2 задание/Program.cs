using System;

namespace _2_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new string[5, 2]
            {
                {"Кристина", "kristinka.g.94@mail.ru"},
                {"Григорий", "grisha@gmail.com"},
                {"Максим", "+7 777 888 1234"},
                {"Елена", " +7 707 352 4561"},
                {"Кристина2", "+7 707 352 4005"}
            };

            string a = Console.ReadLine();
            Console.WriteLine("Введите имя");
            switch (a)
            {
                case "Кристина":
                    Console.WriteLine("kristinka.g.94@mail.ru");
                    break;
                case "Григорий":
                    Console.WriteLine("grisha@gmail.com");
                    break;
                case "Максим":
                    Console.WriteLine("+7 777 888 1234");
                    break;
                case "Елена":
                    Console.WriteLine("+7 707 352 4561");
                    break;
                case "Кристина2":
                    Console.WriteLine("+7 707 352 4005");
                    break;
            }


            Console.WriteLine();

        }
    }
}
