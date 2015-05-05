using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsWeb.Models.Repository
{
    public interface ICategoryDataContext
    {
        Task<IList<Category>> GetAllAsync();
        Task Add(Category category);
        Task<Category> GetByIdAsync(Guid id);
    }
}