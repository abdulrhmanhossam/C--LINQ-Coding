using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTut06.Pagination
{
    public static class Extensions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source,
            int pageIndex = 1, int size = 10) where T : class
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            if (size <= 0)
            {
                pageIndex = 10;
            }

            var result = source.Skip((pageIndex - 1) * size).Take(size);

            return result;
        }
    }
}
