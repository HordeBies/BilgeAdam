using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    internal class Store
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
