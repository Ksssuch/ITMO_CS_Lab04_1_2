namespace Utils
{
    using System;

    public class Utils
    {
        public static void Swap(ref int a,ref int b)
        {
            int temp=a;
            a = b;
            b = temp;
        }
       public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}
