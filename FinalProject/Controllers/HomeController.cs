using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Student model)
        {
            using (var context = new FinalProjectEntities())
            {
                context.Students.Add(model);
                context.SaveChanges();

            }
            string message = "Created the record successfully";

            ViewBag.message = message;
            return View();
        }

        public ActionResult
           Read()
        {
            using (var context = new FinalProjectEntities())
            {


                var data = context.Students.ToList();
                return View(data);
            }
        }
            public ActionResult Edit(int? StudentID)
            {
            using (var context = new FinalProjectEntities())
            {
                var data = context.Students.Where(x => x.StudentID == StudentID).SingleOrDefault();
                return View(data);
            }

            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? StudentID, Student model)
        {
            using (var context = new FinalProjectEntities())
            {
                var data = context.Students.FirstOrDefault(x => x.StudentID == StudentID);

                if (data != null)
                {
                    data.UserID = model.UserID;
                    data.FirstName = model.FirstName;
                    data.LastName = model.LastName;
                    data.PhoneNumber = model.PhoneNumber;
                    data.CurrentJobTitle = model.CurrentJobTitle;
                    data.Organization = model.Organization;
                    data.GraduationYear = model.GraduationYear;
                    data.GraduationSemester = model.GraduationSemester;
                    data.ProfileImage = model.ProfileImage;
                    data.GitHubLink = model.GitHubLink;
                    data.LinkedInLink = model.LinkedInLink;
                    data.WantsToMentor = model.WantsToMentor;
                    context.Entry(data).State = EntityState.Modified;
                    context.SaveChanges();

                    return RedirectToAction("Read");
                }
                else
                {
                    ModelState.AddModelError("", "Student not found.");
                    return View(model);
                }
            }
        }
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? StudentID)
        {
            using (var context = new FinalProjectEntities())
            {
                var data = context.Students.FirstOrDefault(x => x.StudentID == StudentID);
                if (data != null)
                {
                    context.Students.Remove(data);
                    context.SaveChanges();
                    return RedirectToAction("Read");
                }
                else
                {
                    return View();
                }
            }
        }

        public ActionResult Mentorcreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Assignmentcreate(Mentor model)
        {
            using (var context = new FinalProjectEntities())
            {
                context.Mentors.Add(model);
                context.SaveChanges();

            }
            string message = "Created the record successfully";

            ViewBag.message = message;
            return View();
        }
        public ActionResult
           MentorRead()
        {
            using (var context = new FinalProjectEntities())
            {


                var data = context.Mentors.ToList();
                return View(data);
            }
        }
        public ActionResult MentorUpdate(int? MentorID)
        {
            using (var context = new FinalProjectEntities())
            {
                var data = context.Mentors.Where(x => x.MentorID == MentorID).SingleOrDefault();
                return View(data);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MentorUpdate(int? MentorID,Mentor model)
        {
            using (var context = new FinalProjectEntities())
            {
                var data = context.Mentors.FirstOrDefault(x => x.MentorID == MentorID);

                if (data != null)
                {
                    data.StudentID = model.StudentID;
                    data.FirstName = model.FirstName;
                    data.LastName = model.LastName;
                    data.Email = model.Email;
                    data.PhoneNumber = model.PhoneNumber;
                    data.CurrentJobTitle = model.CurrentJobTitle;
                    data.Organization = model.Organization;
                    data.ProfileImage = model.ProfileImage;
                    data.GraduationYear = model.GraduationYear;
                    data.GraduationSemester = model.GraduationSemester;
                    data.GitHubLink = model.GitHubLink;
                    data.LinkedInLink = model.LinkedInLink;   
                    context.Entry(data).State = EntityState.Modified;
                    context.SaveChanges();

                    return RedirectToAction("AssignmentsRead");
                }
                else
                {
                    ModelState.AddModelError("", "Assignment not found.");
                    return View(model);
                }
            }
        }
        public ActionResult MentorDelete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MentorDelete(int? MentorID)
        {
            using (var context = new FinalProjectEntities())
            {
                var data = context.Mentors.FirstOrDefault(x => x.MentorID == MentorID);
                if (data != null)
                {
                    context.Mentors.Remove(data);
                    context.SaveChanges();
                    return RedirectToAction("MentorRead");
                }
                else
                    return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(int? Users)
        {
            using (var context = new FinalProjectEntities())
            {
                var data = context.Users.FirstOrDefault(x => x.UserID == Users);
                if (User != null)
                {
                        if (User.AccessLevel == 1)
                        {

                        }
                        else if (context.Users. == 0)
                        {
                            return RedirectToAction("Read", "Read");
                        }
                        else
                        {
                            return RedirectToAction("create", "create");
                        }
                    }
                }

            }
        }
    }