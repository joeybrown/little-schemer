using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    public static class Challenges
    {
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable) => !enumerable.Any();
        
        public static bool EqualsList<T>(this IEnumerable<T> list1, IEnumerable<T> list2)
        {
            if (list1.IsEmpty() && list2.IsEmpty())
                return true;
            if (list1.IsEmpty() || list2.IsEmpty())
                return false;

            return list1.First().Equals(list2.First()) &&
                   list1.Skip(1).EqualsList(list2.Skip(1));

        }
    }
}
