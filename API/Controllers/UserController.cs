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
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("GetAllUsers")]
        public async Task<List<User>> GetAllUsers()
        {
            return await _userManager.GetAllUsers();
        }

        [HttpGet("getusersbyuserid/{id}")]
        public async Task<User> GetUsersByUserId(int id)
        {
            return await _userManager.GetUserByUserId(id);
        }

        [HttpGet("usersearchvalue/{userSearchValue}")]
        public async Task<List<User>> GetUsersBySearchValue(string userSearchValue)
        {
            return await _userManager.GetUsersBySearchValue(userSearchValue);
        }

        [HttpPost("updateuser")]
        public async Task<int> UpdateUser([FromBody] User User)
        {
            return await _userManager.UpdateUser(User);
        }

        [HttpPut("createuser/{id}")]
        public async Task<int> CreateUser(int id, [FromBody] User User)
        {
            return await _userManager.CreateUser(User);
        }

        [HttpDelete("deleteuser/{id}")]
        public async Task<int> DeleteUser(int id)
        {
            return await _userManager.DeleteUser(id);
        }
    }
}
