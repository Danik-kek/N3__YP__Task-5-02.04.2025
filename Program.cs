namespace N3__YP__Task_5_02._04._2025_
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double Y;
            if (x < 0)
            {
            Y = Math.Pow(x, 2) - 3 - Math.Cbrt(Math.PI - x);
            }
            else if (x >= 0 && x < 1)
            {
                Y = Math.Pow(Math.Pow(x, 2) + 3, 2) - Math.Sqrt(0.5 * Math.PI + x);
            }
            else
            {
                Y = x * (Math.Pow(x, 2) + 3) + Math.Log(Math.PI + x);
            }
            Console.WriteLine($"Значение функции Y при x = {x:F2} равно: {Y:F6}");
        }
    }
}
