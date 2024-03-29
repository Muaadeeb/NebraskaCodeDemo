﻿using System;
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

        [HttpGet("getallsubcategories")]
        public async Task<List<Category>> GetAllSubCategories()
        {
            return await _categoryManager.GetAllCategories();
        }

        [HttpGet("getcategorybycategoryid/{id}")]
        public async Task<Category> GetCategoryByCategoryId(int id)
        {
            return await _categoryManager.GetCategoryByCategoryId(id);
        }

        [HttpGet("categorysearchvalue/{categorySearchValue}")]
        public async Task<List<Category>> GetCategoriesBySearchValue(string categorySearchValue)
        {
            return await _categoryManager.GetCategoriesBySearchValue(categorySearchValue);
        }

        [HttpPost("updatecategory")]
        public async Task<int> UpdateCategory([FromBody] Category department)
        {
            return await _categoryManager.UpdateCategory(department);
        }

        [HttpPut("createcategory{id}")]
        public async Task<int> CreateCategory(int id, [FromBody] Category department)
        {
            return await _categoryManager.CreateCategory(department);
        }

        [HttpDelete("deletecategory/{id}")]
        public async Task<int> DeleteCategory(int id)
        {
            return await _categoryManager.DeleteCategory(id);
        }

    }
}
