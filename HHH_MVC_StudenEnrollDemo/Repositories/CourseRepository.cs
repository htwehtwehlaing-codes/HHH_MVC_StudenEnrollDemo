using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HHH_MVC_StudenEnrollDemo.Models;

namespace HHH_MVC_StudenEnrollDemo.Repositories
{
    public class CourseRepository
    {
        static List<Course> _courses = new List<Course> {
            new Course{Id=1,Name="C# Basics",Instructor="Alice",DurationTime="6 weeks",CourseFee=300},
            new Course{Id=2,Name="ASP.NET MVC",Instructor="Bob",DurationTime="8 weeks",CourseFee=450},
            new Course{Id=3,Name="SQL Dev",Instructor="Carol",DurationTime="4 weeks",CourseFee=250}
        };
        public IEnumerable<Course> GetAllCourses() => _courses;
    }
}