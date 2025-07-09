using System.Web.Mvc;
using HHH_MVC_StudenEnrollDemo.Models;
using HHH_MVC_StudenEnrollDemo.Repositories;

namespace HHH_MVC_StudenEnrollDemo.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Register() => View();

        [HttpPost]
        public ActionResult Register(Student s)
        {
            if (ModelState.IsValid)
            {
                StudentRepository.Add(s);
                ViewBag.Message = "Registered successfully!";
            }
            return View();
        }

        public ActionResult List() => View(StudentRepository.GetAll());

        [HttpPost]
        public ActionResult Update(Student s)
        {
            if (ModelState.IsValid)
                StudentRepository.Update(s);
            return Json(s);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            StudentRepository.Delete(id);
            return Json(new { success = true });
        }

    }
}