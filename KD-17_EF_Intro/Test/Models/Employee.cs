using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    internal class Employee
    {
        [Required]
        public int Id { get; set; }

        // First Name
        public string FirstName { get; set; }
        // Last Name
        public string LastName { get; set; }
        // City
        public string? City { get; set; }
    }
}
