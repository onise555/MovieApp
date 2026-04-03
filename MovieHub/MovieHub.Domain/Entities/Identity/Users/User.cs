using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Identity.Users
{
    public class User:BaseEntity
    {

        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public UserRole Role { get; private set; } 
        public bool IsActive { get; private set; } = true;

        public DateTime? LastLoginAt { get; set; }


        public UserSecurity Security { get; set; } = null!;
        public UserDetail? Detail { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();




    }
}
