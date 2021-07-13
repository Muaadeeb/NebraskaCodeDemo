using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace Business.Interfaces
{
    public interface ISubCategoryManager
    {
        Task<int> CreateSubCategory(Common.Models.SubCategory type);
        Task<int> UpdateSubCategory(Common.Models.SubCategory type);
        Task<int> DeleteSubCategory(int typeId);
        Task<List<SubCategory>> GetSubCategoriesBySearchValue(string searchValue);
        Task<SubCategory> GetSubCategoryBySubCategoryId(int typeId);
        Task<List<SubCategory>> GetAllSubCategories();
    }
}
