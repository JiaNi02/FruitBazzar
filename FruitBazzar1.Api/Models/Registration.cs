namespace FruitBazzar1.Api.Models
{
    public class Registration
    {
        public string Id { get; set; }
        public string UserName { get; set; } 
        public string Password { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
    }
}
