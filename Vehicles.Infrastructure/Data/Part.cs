using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Infrastructure.Data.Enums;

namespace Vehicles.Infrastructure.Data
{
    public class Part
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public Make make { get; set; }

        public Model Model { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
