using System;

namespace CountingPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases
           // RunTestCase(2, 2);
          //  RunTestCase(0, 7);
            RunTestCase(0, 0);
        }
        static void RunTestCase(int x, int y)
        {
            var pathCounter = new PathCounter();
            var numberOfPaths = pathCounter.CountPaths(x, y);
            Console.WriteLine($"Number of valid paths from (0, 0) to ({x}, {y}): {numberOfPaths}");

            var pathPrinter = new PathPrinter();
            var paths = pathPrinter.FindPaths(x, y);
            Console.WriteLine($"Routes for each valid path:");
            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }
            Console.WriteLine();
        }
    }
}
