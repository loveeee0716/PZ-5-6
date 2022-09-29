namespace PZ_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 1");
            for (int i = 10; i < 90; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание № 2");
            for (char a = 'Б'; a != 'З'; a++)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Задание № 3");
            for (int s = 0; s < 5; s++)
            {
                for (int g = 0; g < 7; g++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание № 4");
            for (int q = 0; q < 101; q++)
            {
                if (q % 8 == 0)
                    Console.WriteLine(q);
            }
            Console.WriteLine("Задание № 5");
            for (int p = 3, v = 60; v - p != 13; p++)
                Console.WriteLine(p);
        }
    }
}