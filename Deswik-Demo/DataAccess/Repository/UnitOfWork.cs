using DataAccess.Entities;
using System;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private RecipeDbContext _context;

        public UnitOfWork(RecipeDbContext context)
        {
            this._context = context;
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }
    }
}
