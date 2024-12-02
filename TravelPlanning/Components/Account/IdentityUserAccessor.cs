using TravelPlanning.Data;
using Microsoft.AspNetCore.Identity;

namespace TravelPlanning.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<TravelPlanningUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<TravelPlanningUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
