using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HHH_MVC_StudenEnrollDemo.Repositories;

namespace HHH_MVC_StudenEnrollDemo.Controllers
{
    public class CourseController : Controller
    {
        CourseRepository _repo = new CourseRepository();
        public ActionResult Index() => View(_repo.GetAllCourses());
    }

}