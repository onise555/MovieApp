using MovieHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Domain.Entities.Features
{
    public class Genre:BaseEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}
