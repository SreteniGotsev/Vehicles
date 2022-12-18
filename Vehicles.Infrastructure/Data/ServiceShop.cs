using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Infrastructure.Data.Enums;

namespace Vehicles.Infrastructure.Data
{
    public class ServiceShop
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid UserId { get; set; }
        [Required]
        public User User { get; set; }

        public ICollection<CategoryVehicle> CategoryVehicles { get; set; } = new List<CategoryVehicle>();
    }
}
