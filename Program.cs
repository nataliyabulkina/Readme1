/*
Задача.   Написать программу, которая из имеющегося массива строк формирует массив строк, 
длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/
namespace Massword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Массив строк";
            string[] s = new string [100];
            int n;
            Console.WriteLine("Задайте количество элементов : ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }
            Console.WriteLine ("Массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write (s[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
