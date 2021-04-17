using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentScholarshipRegistration.Models;

namespace StudentScholarshipRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        StudentScholarshipdbContext db;

        public RegistrationController()
        {
            db = new StudentScholarshipdbContext();
        }
        // GET: Registration
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(scholarshipdetail model)
        {
            var checkId = db.scholarshipdetails.Where(x => x.student_Id == model.student_Id).FirstOrDefault();
            {
                if (checkId == null)
                {



                    if (ModelState.IsValid)
                    {
                        db.scholarshipdetails.Add(model);
                        db.SaveChanges();
                        ViewBag.SuccessMessage = "Your details are submitted successfully";
                        


                    }
                }
                else
                {
                    ViewBag.Message = "Student Id already Exists";
                    return View();
                }
                ModelState.Clear();
                return View(model);
                




            }
        }
    }
}
