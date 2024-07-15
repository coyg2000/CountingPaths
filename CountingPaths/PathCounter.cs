using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingPaths
{
    public class PathCounter
    {
        private readonly Dictionary<(int, int, int, int), long> _memo = new Dictionary<(int, int, int, int), long>();

        public long CountPaths(int x, int y, int eastStreak = 0, int northStreak = 0)
        {
            if (x == 0 && y == 0) return 1;
            if (eastStreak == 3 || northStreak == 3) return 0;

            if (_memo.ContainsKey((x, y, eastStreak, northStreak)))
                return _memo[(x, y, eastStreak, northStreak)];

            long paths = 0;
            if (x > 0)
                paths += CountPaths(x - 1, y, eastStreak + 1, 0);
            if (y > 0)
                paths += CountPaths(x, y - 1, 0, northStreak + 1);

            _memo[(x, y, eastStreak, northStreak)] = paths;
            return paths;
        }
    }
}
