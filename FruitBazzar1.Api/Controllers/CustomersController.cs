using FruitBazzar1.Api.Models;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace FruitBazzar1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public CustomersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("GetAllCustomers")]
        public JsonResult GetCustomers()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DeafultConnection").ToString());
            SqlDataAdapter da = new SqlDataAdapter("Select* FROM Customers", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Customers> customersList = new List<Customers>();
            if(dt.Rows.Count > 0)
            {
                Customers customer = new Customers();
                //customer.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                //customer.Name = Convert.ToString(dt.Rows[i]["Name"]);
                //customer.Email = Convert.ToString(dt.Rows[i]["Email"]);
                //customer.PhoneNumber = Convert.ToInt32(dt.Rows[i]["PhoneNumber"]);
                //customer.Password = Convert.ToString(dt.Rows[i]["Password"]);
                customersList.Add(customer);
            }
            if (customersList.Count > 0)
                JsonConvert.SerializeObject(customersList);
        }
    }
}
