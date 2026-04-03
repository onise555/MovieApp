using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Identity.Users
{
    public class UserSecurity:BaseEntity
    {
        public string PasswordHash { get; set; }    = string.Empty;

        public bool IsEmailConfirmed { get; set; } = false;
        public string? EmailConfirmationToken { get; set; }


        public string? ForgotPassword { get; set; }
        public DateTime? ForgotPasswordExpiry { get; set; }

        //კავშირი One To One 
        public int UserId { get; set; }
        public  User User { get; set; } = null!;
    }
}
