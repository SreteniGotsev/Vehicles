using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Infrastructure.Data
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Account Accounnt { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string Region { get; set; }

        [Required]
        public Guid CartId { get; set; }
        [Required]
        public Cart Cart { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();

        public ICollection<Part> Parts { get; set; } = new List<Part>();

        [Required]
        public Guid ServiceShopId { get; set; }

        [Required]
        public ServiceShop ServiceShop { get; set; }

        [Required]
        public Guid CarWashId { get; set; }

        [Required]
        public CarWash CarWash { get; set; }
    }
}
