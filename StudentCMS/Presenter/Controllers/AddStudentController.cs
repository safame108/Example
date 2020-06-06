using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuisnessObject;
using BuisnessLogic;

namespace Presenter.Controllers
{
    public class AddStudentController : Controller
    {
        // GET: AddStudent
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(StudentOB student)
        {
            if (ModelState.IsValid) {
                StudentBL objstudent = new StudentBL();
                CustomBO CBO = objstudent.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}