using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryManager _subCategoryManager;

        public SubCategoryController(ISubCategoryManager subCategoryManager)
        {
            _subCategoryManager = subCategoryManager;
        }

        [HttpGet("getallsubcategories")]
        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            return await _subCategoryManager.GetAllSubCategories();
        }

        [HttpGet("getsubcategorybysubcategoryid/{id}")]
        public async Task<SubCategory> GetSubCategoryBySubCategoryId(int id)
        {
            return await _subCategoryManager.GetSubCategoryBySubCategoryId(id);
        }

        [HttpGet("subcategorysearchvalue/{subCategorySearchValue}")]
        
        public async Task<List<SubCategory>> GetSubCategoriesBySearchValue(string subCategorySearchValue)
        {
            return await _subCategoryManager.GetSubCategoriesBySearchValue(subCategorySearchValue);
        }

        [HttpPost("updatesubcategory")]
        public async Task<int> UpdateSubCategory([FromBody] SubCategory type)
        {
            return await _subCategoryManager.UpdateSubCategory(type);
        }

        [HttpPut("createsubcategory{id}")]
        public async Task<int> CreateSubCategory(int id, [FromBody] SubCategory type)
        {
            return await _subCategoryManager.CreateSubCategory(type);
        }

        [HttpDelete("deletesubcategory/{id}")]
        public async Task<int> DeleteSubCategory(int id)
        {
            return await _subCategoryManager.DeleteSubCategory(id);
        }
    }
}
