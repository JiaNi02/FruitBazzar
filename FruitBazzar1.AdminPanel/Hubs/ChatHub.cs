using Microsoft.AspNetCore.SignalR;

namespace FruitBazzar1.AdminPanel.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToAll(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
