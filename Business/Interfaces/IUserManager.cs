using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace Business.Interfaces
{
    public interface IUserManager
    {
        Task<int> CreateUser(User user);
        Task<int> UpdateUser(User user);
        Task<int> DeleteUser(int userId);
        Task<List<User>> GetUsersBySearchValue(string searchValue);
        Task<User> GetUserByUserId(int userId);
        Task<List<User>> GetAllUsers();
    }
}
