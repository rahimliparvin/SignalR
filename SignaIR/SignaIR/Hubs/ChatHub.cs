using Microsoft.AspNetCore.SignalR;

namespace SignaIR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string username ,string message)
        {
            await Clients.All.SendAsync("RecieveMessage",username,message);
        }
    }
}
