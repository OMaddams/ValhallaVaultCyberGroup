using Microsoft.AspNetCore.Identity;
using ValhallaVaultCyberGroup.Data.Models.Result;

namespace ValhallaVaultCyberGroup.Ui.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ResultModel Result { get; set; }
       
    }

}
