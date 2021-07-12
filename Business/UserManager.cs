using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Common.Models;

namespace Business
{
    public class UserManager : IUserManager
    {
        public async Task<int> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsersBySearchValue(string searchValue)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
