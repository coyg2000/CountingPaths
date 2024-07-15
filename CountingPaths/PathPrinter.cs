using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingPaths
{
    public class PathPrinter
    {
        public List<string> FindPaths(int x, int y)
        {
            var paths = new List<string>();
            GeneratePaths(x, y, "", 0, 0, paths);
            return paths;
        }

        private void GeneratePaths(int x, int y, string path, int eastStreak, int northStreak, List<string> paths)
        {
            if (x == 0 && y == 0)
            {
                paths.Add(path);
                return;
            }

            if (eastStreak < 3 && x > 0)
                GeneratePaths(x - 1, y, path + "E", eastStreak + 1, 0, paths);

            if (northStreak < 3 && y > 0)
                GeneratePaths(x, y - 1, path + "N", 0, northStreak + 1, paths);
        }
    }
}
