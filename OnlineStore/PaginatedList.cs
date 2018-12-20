﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(items);
        }

        public bool HasPreviousPage => (PageIndex > 1);
        
        public bool HasNextPage => (PageIndex < TotalPages);

        public static PaginatedList<T> CreateAsync(
            List<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            List<T> items = source.Skip(
                (pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        internal static Task<PaginatedList<Item>> CreateAsync(object p, int v, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}