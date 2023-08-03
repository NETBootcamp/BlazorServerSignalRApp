using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Server.Hubs;

public class CountHub : Hub
{
    public async Task SendMessage(int count)
    {
        await Clients.All.SendAsync("ReceiveMessage", count);
    }
}