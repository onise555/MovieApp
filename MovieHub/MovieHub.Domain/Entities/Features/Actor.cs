using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Features
{
    public class Actor:BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Biography { get; set; }
        public string? PhotoUrl { get; set; }
        public Gender Gender { get; set; } = Gender.NotSpecified;
        public DateTime? BirthDate { get; set; }

    }
}
