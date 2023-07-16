using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patric_God.ControllerService;
using Patric_God.Data;
using Patric_God.Models;

namespace Patric_God.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DBContext _context;
        private readonly IUser _InterFaceUser;

        public UserController(DBContext context , IUser InterFaceUser)
        {
            _context = context;
            _InterFaceUser = InterFaceUser;
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<User>> GetUser(int Id)
        {
            var getUser = await _InterFaceUser.GetUser(Id);

            if (getUser == null)
            {
                return NotFound();
            }
            return Ok(getUser);
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User User)
        {
            var newUser = await _InterFaceUser.CreateUser(User);
            if (newUser == null)
            {
                return NotFound();
            }
            return Ok(newUser);

        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(User User)
        {
            var UserUpdate = await _InterFaceUser.UpdateUser(User);
            await _context.SaveChangesAsync();

            if (UserUpdate != null)
            {
                return Ok(UserUpdate);
            }

            return NotFound();
        }
        [HttpDelete]
        public async Task<ActionResult<User>> DeleteUser(int UserId)
        {
            var deleteUser = await _InterFaceUser.DeleteUser(UserId);
            if (deleteUser != null)
            {
                return Ok(deleteUser);
            }
            return NotFound();
        }
    }
}
