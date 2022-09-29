namespace PZ_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение t: ");
            int t = Convert.ToInt32(Console.ReadLine());
            double y;
            double x = -2;
            while (x <= 12)
            {
                if (x < 0)
                    y = t;
                else if (0 <= x && x < 10)
                    y = t * x;
                else
                    y = 2 * t;
                x += 2;
                Console.WriteLine(y);
            }
    }
}