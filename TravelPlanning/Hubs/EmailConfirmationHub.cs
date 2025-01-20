using Microsoft.AspNetCore.SignalR;

namespace TravelPlanning.Hubs
{
    public class EmailConfirmationHub : Hub
    {
        public async Task EmailConfirmed(string email)
        {
            await Clients.Group(email).SendAsync("EmailConfirmed", email);
        }
    }
}
