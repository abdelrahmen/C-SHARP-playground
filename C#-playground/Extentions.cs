﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__playground
{
    public static class Extentions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page=1, int size=10) where T : class
        {
            if (page<=0)
            {
                page = 1;
            }
            if (size<=0)
            {
                size = 10;
            }
            var completeListLength = source.Count();

            var pages = (int)Math.Ceiling((decimal)completeListLength / size);

            var result = source.Skip((page-1)*size).Take(size);

            return result;
        }
    }
}
