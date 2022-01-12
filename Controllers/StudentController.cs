using SchoolMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolMvc.Controllers
{
    public class StudentController : Controller
    {
        Student[] stuArray = new Student[] { new Student(1, "amir", "mango", 27), new Student(2, "matan", "sayas", 24), new Student(3, "lior", "yosef", 25), new Student(4, "jacob", "shiber", 22) };
        // GET: Student
        public ActionResult Index()
        {
            //ViewBag.Name = "amir";
            ViewBag.Students = stuArray[0].FirstName;
            return View();
        }
        public ActionResult GetAllStudents()
        {
            return View(stuArray);
        }
        public ActionResult GetStudentById(int id)
        {
            Student student = stuArray.First(x => x.Id == id);
            ViewBag.stu=student;
            return View();
           
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
