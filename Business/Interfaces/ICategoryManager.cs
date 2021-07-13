using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Type = System.Type;

namespace Business.Interfaces
{
    public interface ICategoryManager
    {
        Task<int> CreateCategory(Category department);
        Task<int> UpdateCategory(Category department);
        Task<int> DeleteCategory(int departmentId);
        Task<List<Category>> GetCategoriesBySearchValue(string searchValue);
        Task<Category> GetCategoryByCategoryId(int departmentId);
        Task<List<Category>> GetAllCategories();
    }
}
