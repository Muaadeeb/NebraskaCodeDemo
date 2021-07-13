using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using SubCategory = Common.Models.SubCategory;

namespace Business
{
    public class SubCategoryManager : ISubCategoryManager
    {
        public async Task<int> CreateSubCategory(SubCategory type)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateSubCategory(SubCategory type)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteSubCategory(int typeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubCategory>> GetSubCategoriesBySearchValue(string searchValue)
        {
            throw new NotImplementedException();
        }

        public async Task<SubCategory> GetSubCategoryBySubCategoryId(int typeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            throw new NotImplementedException();
        }
    }
}
