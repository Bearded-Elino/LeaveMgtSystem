using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }=string.Empty;
        [Required]
        [StringLength(50)]
        public string Password { get; set; }=string.Empty;

        public string Role {get; set; }=string.Empty;

    }
}