using Microsoft.AspNetCore.SignalR;

namespace TravelPlanning.Hubs
{
    public class EmailConfirmationHub : Hub
    {
        public async Task ConfirmationComplete(string email)
        {
            await Clients.All.SendAsync("EmailConfirmed", email);
        }
    }
}
