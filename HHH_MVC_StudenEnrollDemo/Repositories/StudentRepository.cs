using System;
using System.Collections.Generic;
using System.Linq;
using HHH_MVC_StudenEnrollDemo.Models;

namespace HHH_MVC_StudenEnrollDemo.Repositories
{
    public static class StudentRepository
    {
        static List<Student> _students = new List<Student>();

        public static void Add(Student s)
        {
            s.Id = _students.Count + 1;
            _students.Add(s);
        }
        public static IEnumerable<Student> GetAll() => _students;
        public static void Update(Student s)
        {
            var e = _students.FirstOrDefault(x => x.Id == s.Id);
            if (e != null)
            {
                e.Name = s.Name; e.Email = s.Email;
                e.DOB = s.DOB; e.CourseName = s.CourseName;
            }
        }
        public static void Delete(int id)
        {
            var e = _students.FirstOrDefault(x => x.Id == id);
            if (e != null) _students.Remove(e);
        }
    }
}