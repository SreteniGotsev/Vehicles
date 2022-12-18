using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Infrastructure.Data.Enums;

namespace Vehicles.Infrastructure.Data
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]

        public Make Make { get; set; }

        [Required]
        public Model Model { get; set; }

        [MaxLength(100)]
        public string Modification { get; set; }

        [Required]
        public CategoryVehicle Category { get; set; }

        [MaxLength(100)]
        public string Engine { get; set; }

        [MaxLength(100)]
        public string Specifications { get; set; }

        [Range(0.0, 1000000.0)]
        public decimal Price { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public User User { get; set; }

    }
}
