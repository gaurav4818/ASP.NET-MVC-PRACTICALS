using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Practical12Test2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
       
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        [Required]
        public int Salary { get; set; }
      
        public int DesignationId { get; set; }
        public virtual Designation designations { get; set; } 
    }
}