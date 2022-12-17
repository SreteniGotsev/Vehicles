
using Microsoft.AspNetCore.Identity;

namespace Vehicles.Infrastructure.Data
{
    public class Account : IdentityUser
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}