using FruitBazzar1.Api.Data;
using FruitBazzar1.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FruitBazzar1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FruitBazzarApidbcontext fruitBazzarApidbcontext;
        public UserController(FruitBazzarApidbcontext fruitBazzarApidbcontext)
        {
            this.fruitBazzarApidbcontext = fruitBazzarApidbcontext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Users>>> Get()=> Ok(await fruitBazzarApidbcontext.User.ToListAsync());
        [HttpPost]
        public async Task<ActionResult<Users>> Add(Users users)
        {
            if (users != null)
            { 
                var result = fruitBazzarApidbcontext.User.Add(users).Entity;
                await fruitBazzarApidbcontext.SaveChangesAsync();
                return Ok(result);
            }
            return BadRequest("Invalid Request");
        }
        [HttpGet("{email}/{password}")]
        public async Task<ActionResult<Users>> Login(string email, string password)
        {
            if(email is not null && password is not null)
            {
                var users = await fruitBazzarApidbcontext.User
                    .Where(x => x.Email!.ToLower().Equals(email.ToLower()) && x.Password == password)
                    .FirstOrDefaultAsync();
                return users != null ? Ok(users) : NotFound("User not found");
            }
            return BadRequest("Invalid Request");
        }
    }
}
