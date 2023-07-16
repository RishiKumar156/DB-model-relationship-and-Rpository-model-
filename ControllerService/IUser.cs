using Microsoft.AspNetCore.Mvc;
using Patric_God.Models;

namespace Patric_God.ControllerService
{
    public interface IUser
    {
        Task<User> GetUser(int Id);
        Task<User> CreateUser(User User);
        Task <User> UpdateUser(User User);
        Task<User> DeleteUser(int UserId);
    }
}
