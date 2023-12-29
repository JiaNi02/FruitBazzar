using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FruitBazzar1.Api.Models;
using Microsoft.Data.SqlClient;

namespace FruitBazzar1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("registration")]
        public string registration (Registration registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection".ToString()));
            SqlCommand cmd = new SqlCommand("INSERT INTO Registration(UserName, Password, IsActive) VALUES('"+registration.UserName+ "','"+registration.Password+"','"+registration.Email+"', '"+registration.IsActive+"')", con);
            int i = cmd.ExecuteNonQuery();
            if(i > 0)
            {
                return "Data inserted";
            }
            else
            {
                return "Error";
            }
        }

    }
}
