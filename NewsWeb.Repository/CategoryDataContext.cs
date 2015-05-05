using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using NewsWeb.Models;
using NewsWeb.Models.Repository;

namespace NewsWeb.Repository
{
    public class CategoryDataContext : BaseDataContext, ICategoryDataContext
    {
        public CategoryDataContext(IApplicationDbContext context) : base(context)
        { }

        public async Task<IList<Category>> GetAllAsync()
        {
            return await Context.Categories.ToListAsync();
        }

        public async Task Add(Category category)
        {
            Context.Categories.Add(category);
            await Context.SaveChangesAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await Context.Categories.FindAsync(id);
        }
    }
}
