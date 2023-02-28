﻿using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain;
using OnlineAccountingAppServer.Persistence.Context;

namespace OnlineAccountingAppServer.Persistence
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private CompanyDbContext _context;

        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }

        public async Task<int> SaveChangesAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count;
        }
    }
}
