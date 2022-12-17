using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Infrastructure.Data
{
    public class Cart
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public User User { get; set; }

        public ICollection<Part> Parts { get; set; } = new List<Part>();
    }
}
