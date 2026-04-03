using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Identity.Users
{
    public class UserDetail:BaseEntity
    {
        public string? ProfileImg { get; set; }
        public string? Biography { get; set; }
        public string? ThemeColor { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;


    }
}
