using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class EmployeeViewModal
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        public string Gender { get; set; }
    }
}