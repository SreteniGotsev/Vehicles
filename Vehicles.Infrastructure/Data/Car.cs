using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Infrastructure.Data.Enums;

namespace Vehicles.Infrastructure.Data
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Make Make { get; set; }

        public Model Model { get; set; }

        public string Modification { get; set; }

        public CategoryVehicle Category { get; set; }

        public string Engine { get; set; }

        public string Specifications { get; set; }

        public decimal Price { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

    }
}
