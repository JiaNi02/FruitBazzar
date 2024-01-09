

namespace FruitBazzar1.Repository;

public class UserService : IUserRepository
{
    public async Task<Users> Login(string email, string password)
    {
        var client = new HttpClient();
        string url = "https://10.0.2.2:7207/api/User" + email + "/" + password;
        client.BaseAddress = new Uri(url);
        HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
        if(response.IsSuccessStatusCode)
        {
            string content = response.Content.ReadAsStringAsync().Result;
            Users users = JsonConvert.DeserializeObject<Users>(content);
            return await Task.FromResult(users);
        }
        return null!;
    }
}

