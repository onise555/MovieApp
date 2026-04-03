using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Identity.Users
{
 public class RefreshToken:BaseEntity
    {

        public string Token { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }
        public bool IsExpired => DateTime.UtcNow >= ExpiresAt;
        public DateTime? RevokedAt { get; set; }

        public bool IsActive => RevokedAt == null && !IsExpired;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
