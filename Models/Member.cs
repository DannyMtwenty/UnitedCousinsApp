using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitedCousinsApp.Models
{
    public class Member
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public string Contacts { get; set; }
       // [Required]
       // [StringLength(50)]
      
        public string Age { get; set; }
        public bool Married { get; set; }
        public Role? Role { get; set; }
        public int? RoleId { get; set; }
    }
}
