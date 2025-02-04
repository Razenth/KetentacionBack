using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}