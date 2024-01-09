

namespace FruitBazzar1.Repository
{
    public interface IUserRepository
    {
        Task<Users> Login(string email, string password);
    }
}
