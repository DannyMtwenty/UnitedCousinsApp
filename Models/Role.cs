using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnitedCousinsApp.Models
{
    public class Role
    {
        public int Id { get; set; }
        [StringLength(100)]
      
        public string Name { get; set; }
    }
}
