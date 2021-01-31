using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models.SupportingModels
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public Object ToSimpleObject(int count)
        {
            return new { PageIndex = this.PageIndex, TotalPages = this.TotalPages, totalItems= count, Items = this.ToArray() };
        }

        //public bool HasPreviousPage
        //{
        //    get
        //    {
        //        return (PageIndex > 1);
        //    }
        //}

        //public bool HasNextPage
        //{
        //    get
        //    {
        //        return (PageIndex < TotalPages);
        //    }
        //}

        public static async Task<Object> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        //public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            //var count = await source.CountAsync();
            var count =  source.Count();
            //var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
             return await Task.Run(()=>new PaginatedList<T>(items, count, pageIndex, pageSize).ToSimpleObject(count));
        }
    }
}
