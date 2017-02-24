using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Common
{
    public static class StaticArray
    {
        public static T[] ShallowSubArray<T>(this T[] baseArray, int start, int length)
        {
            return baseArray.Skip(start).Take(length).ToArray();
        }

        public static T[] ShallowSubArray<T>(this T[] baseArray, int start)
        {
            return baseArray.Skip(start).ToArray();
        }
    }
}
