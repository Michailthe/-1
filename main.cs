using System;

namespace MyApplication2
{
    public class MainProgram
    {
        public static void RunProgram()
        {
            Console.WriteLine("Добро пожаловать в мое приложение!");
            
            string name;
            Console.Write("Пожалуйста, введите ваше имя: ");
            name = Console.ReadLine();
            
            Console.WriteLine($"Привет, {name}!");
            
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
