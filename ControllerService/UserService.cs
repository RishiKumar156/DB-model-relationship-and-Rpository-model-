using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patric_God.Data;
using Patric_God.Models;

namespace Patric_God.ControllerService
{
    public class UserService : IUser
    {
        private readonly DBContext _context;

        public UserService(DBContext context) 
        {
            _context = context;
        }

        //see through clearly this only going to return only one user from the DB 
        public async Task<User> GetUser(int Id)
        {
            var user = await _context.NewUser.FindAsync(Id);
            return user;
        }

        public async Task<User> CreateUser(User User)
        {
            await _context.NewUser.AddAsync(User);
            await _context.SaveChangesAsync();
            return User;
        }

        public async Task<User> UpdateUser(User User)
        {
            var db = await _context.NewUser.FindAsync(User.USerID);
            if(db != null)
            {
                db.UserName = User.UserName;
                db.UserDes = User.UserDes;

                await _context.SaveChangesAsync();
            }
            return db;
        }
        
        public async Task<User> DeleteUser(int UserId)
        {
            var db = await _context.NewUser.FindAsync(UserId);
            if (db != null)
            {
                _context.NewUser.Remove(db);
                await _context.SaveChangesAsync();
            }
            return db;
        }

        public  async Task<List<User>> GetUsers()
        {
            var getUser = await _context.NewUser.ToListAsync();
            return getUser;
        }
    }
}
