using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;

namespace Business
{
    public class CategoryManager : ICategoryManager
    {
        public async Task<int> CreateCategory(Category department)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateCategory(Category department)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteCategory(int departmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetCategoriesBySearchValue(string searchValue)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryByCategoryId(int departmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }
    }
}
