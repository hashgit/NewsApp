using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewsWeb.Models;

namespace NewsWeb.Business.Models
{
    public interface ICategoryBusiness
    {
        Task<IList<Category>> GetAllAsync();
        Task AddCategoryAsync(Category category);
        Task<Category> GetByIdAsync(Guid cid);
    }
}