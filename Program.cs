using System;


namespace Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 4;
            Console.Write(checkTriangles(n));
        }
        public static int checkTriangles(int n)
        {

            return (n * (n + 2) * (2 * n + 1) / 8);
        }
    }
}
