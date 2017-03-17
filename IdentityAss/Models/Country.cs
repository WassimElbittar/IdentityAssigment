using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityAss.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}