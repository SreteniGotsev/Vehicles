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
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public Guid CartId { get; set; }

        public Cart Cart { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();

        public ICollection<Part> Parts { get; set; } = new List<Part>();

        public Guid ServiceShopId { get; set; }

        public ServiceShop ServiceShop { get; set; }

        public Guid CarWashId { get; set; }

        public CarWash CarWash { get; set; }
    }
}
