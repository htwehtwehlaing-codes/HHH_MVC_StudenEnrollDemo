using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HHH_MVC_StudenEnrollDemo.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Display(Name = "Course")] public string Name { get; set; }
        [Display(Name = "Instructor")] public string Instructor { get; set; }
        [Display(Name = "Duration")] public string DurationTime { get; set; }
        [Display(Name = "Full Course Fee")] public decimal CourseFee { get; set; }
    }
}