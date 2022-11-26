using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRString
{
    internal class Solution
    {
        public bool CanTransform(string start, string end)
        {
            if (start.Length <= 1 || start.Length != end.Length)
            {
                return false;
            }

            var res = "";

            for (int i = 0; i < start.Length; i++)
            {
                if (i + 2 != start.Length - 1)
                {
                    var subStr = start[i..(i + 2)];

                    if (subStr.Contains("LX"))
                    {
                        var result = subStr.Replace("LX", "XL");
                        res += result;
                        i++;
                    }

                    else if (subStr.Contains("XL"))
                    {
                        var result = subStr.Replace("XL", "LX");
                        res += result;
                        i++;
                    }

                    else if (subStr.Contains("RX"))
                    {
                        var result = subStr.Replace("RX", "XR");
                        res += result;
                        i++;
                    }

                    else if (subStr.Contains("XR"))
                    {
                        var result = subStr.Replace("XR", "RX");
                        res += result;
                        i++;
                    }

                    else
                    {
                        res += subStr;
                    }
                }
            }

            Console.WriteLine(start);
            Console.WriteLine(end);
            Console.WriteLine(res);

            if (res == end)
            {
                return true;
            }

            return false;
        }
    }
}
