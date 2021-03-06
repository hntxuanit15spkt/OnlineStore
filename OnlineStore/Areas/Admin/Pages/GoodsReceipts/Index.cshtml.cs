﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.EF;
using DAL.Models;

namespace OnlineStore.Pages.Admin.GoodsReceipts
{
    public class IndexModel : PageModel
    {
        private readonly DAL.EF.OnlineStoreDbContext _context;

        public IndexModel(DAL.EF.OnlineStoreDbContext context)
        {
            _context = context;
        }

        public IList<GoodsReceipt> GoodsReceipt { get;set; }

        public async Task OnGetAsync()
        {
            GoodsReceipt = await _context.GoodsReceipt
                .Include(g => g.Supplier).ToListAsync();
        }
    }
}
