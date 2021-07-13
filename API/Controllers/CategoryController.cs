using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<List<Category>> GetAllSubCategories()
        {
            return await _categoryManager.GetAllCategories();
        }

        [HttpGet("{id}")]
        public async Task<Category> GetCategoryByCategoryId(int id)
        {
            return await _categoryManager.GetCategoryByCategoryId(id);
        }

        [HttpGet("{searchValue}")]
        [Route("SearchValue")]
        public async Task<List<Category>> GetCategoriesBySearchValue(string searchValue)
        {
            return await _categoryManager.GetCategoriesBySearchValue(searchValue);
        }

        [HttpPost]
        public async Task<int> UpdateCategory([FromBody] Category department)
        {
            return await _categoryManager.UpdateCategory(department);
        }

        [HttpPut("{id}")]
        public async Task<int> CreateCategory(int id, [FromBody] Category department)
        {
            return await _categoryManager.CreateCategory(department);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteCategory(int id)
        {
            return await _categoryManager.DeleteCategory(id);
        }

    }
}
