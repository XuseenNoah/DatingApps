using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{


    public class UsersController : BaseApiController
    {
        private readonly DataContext _data;

        public UsersController(DataContext data)
        {
            _data = data;

        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> Get()
        {
            return await _data.Users.ToListAsync();
        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetApp(int id)
        {
            return await _data.Users.FindAsync(id);
        }
    }
}