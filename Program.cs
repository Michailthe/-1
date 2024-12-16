using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызываем метод из другого класса
            MyApplication2.MainProgram.RunProgram();
        }
    }
}