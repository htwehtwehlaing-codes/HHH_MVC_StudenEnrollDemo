using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HHH_MVC_StudenEnrollDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required, EmailAddress] public string Email { get; set; }
        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Display(Name = "Course Interested")]
        public string CourseName { get; set; }
    }
}