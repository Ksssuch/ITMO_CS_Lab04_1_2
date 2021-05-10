namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            int x;
            int y;
            Console.WriteLine("Enter a number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number(2)");
            y = int.Parse(Console.ReadLine());
            int greater;
            greater = Utils.Greater(x, y);
            if (x > y)
                Console.WriteLine("{0}", x);
            else
                Console.WriteLine("{0}", y);
        }
    }
}
