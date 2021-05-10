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
            Console.WriteLine("The greater value is " + greater);
            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

        }
    }
}
