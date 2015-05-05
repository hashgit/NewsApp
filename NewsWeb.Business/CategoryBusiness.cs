using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewsWeb.Business.Models;
using NewsWeb.Models;
using NewsWeb.Models.Repository;

namespace NewsWeb.Business
{
    public class CategoryBusiness : BusinessManager, ICategoryBusiness
    {
        private readonly ICategoryDataContext _categoryDataContext;

        public CategoryBusiness(ICategoryDataContext categoryDataContext)
        {
            _categoryDataContext = categoryDataContext;
        }

        public async Task<IList<Category>> GetAllAsync()
        {
            return await _categoryDataContext.GetAllAsync();
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _categoryDataContext.Add(category);
        }

        public async Task<Category> GetByIdAsync(Guid cid)
        {
            return await _categoryDataContext.GetByIdAsync(cid);
        }
    }
}