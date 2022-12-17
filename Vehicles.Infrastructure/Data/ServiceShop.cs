using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Infrastructure.Data.Enums;

namespace Vehicles.Infrastructure.Data
{
    public class ServiceShop
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public ICollection<CategoryVehicle> CategoryVehicles { get; set; } = new List<CategoryVehicle>();
    }
}
