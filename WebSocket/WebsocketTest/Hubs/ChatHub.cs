using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebsocketTest.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync("RecieveMessage", username, message);
        }
    }
}
