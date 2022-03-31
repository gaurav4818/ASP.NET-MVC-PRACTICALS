using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Practical12Test2.Models
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string designation { get; set; }

        public virtual List<Employee> emps { get; set; }
        
    }
}