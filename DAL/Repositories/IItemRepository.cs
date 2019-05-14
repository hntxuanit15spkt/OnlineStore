﻿using DAL.Repositories.Base;
using System.Collections.Generic;
using DAL.Data.Entities;
using Utilities.DTOs;

namespace DAL.Repositories
{
    public interface IItemRepository : IRepo<Item>
    {
        IEnumerable<Item> GetByCategory(int categoryId);
        Item GetItem(int? id);
        IEnumerable<Item> GetItemByName(string name);
        PagedResult<Item> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
        void ImportExcel(string filePath, int categoryId);
    }
}