using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBadVersion
{

    public class Solution
    {
        public int FirstBadVersion(int n)
        {

            var a = n / 2;
            var b = (3 * n) / 4;
            var c = n / 4;

            int first = 0;

            if (IsBadVersion(c))
            {
                for (var i = 0; i <= c; i++)
                {
                    first = i;

                    if (IsBadVersion(i))
                    {
                        return first;
                    }
                }
            }

            if (!IsBadVersion(c) && IsBadVersion(a))
            {
                for (var i = c + 1; i <= a; i++)
                {
                    first = i;

                    if (IsBadVersion(i))
                    {
                        return first;
                    }
                }
            }

            if (!IsBadVersion(a) && !IsBadVersion(b))
            {
                for (var i = a + 1; i <= b; i++)
                {
                    first = i;

                    if (IsBadVersion(i))
                    {
                        return first;
                    }
                }
            }

            for (var i = b; i <= n; i++)
            {
                first = i;

                if (IsBadVersion(i))
                {
                    return first;
                }
            }
            return first;
        }

        private bool IsBadVersion(int n)
        {
            if (n >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
