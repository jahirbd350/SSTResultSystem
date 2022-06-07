using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSTResultSystem.Models;

namespace SSTResultSystem.Controllers
{
    public class ReportController : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReportGeneration(FormCollection form)
        {
            //string StudentId = form["StudentId"].ToString();
            String ExamTerm = form["ExamTerm"].ToString();
            string Semester = form["Semester"].ToString();
            //Console.WriteLine(StudentId);
            switch (Semester)
            {
                case "1st":
                    try
                    {
                        result11 result = db.result11.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("semresult", "result11", new { examterm = result.examterm });
                    }
                    catch (Exception ex)
                    {
                        Session["err"] = ex.Message + " No Data Found!";
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                case "2nd":
                    try
                    {
                        result12 result = db.result12.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("details", "result12", new { id = result.id });
                    }
                    catch (Exception ex)
                    {
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                case "3rd":
                    try
                    {
                        result21 result = db.result21.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("details", "result21", new { id = result.id });
                    }
                    catch (Exception ex)
                    {
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                case "4th":
                    try
                    {
                        result22 result = db.result22.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("details", "result22", new { id = result.id });
                    }
                    catch (Exception ex)
                    {
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                case "5th":
                    try
                    {
                        result31 result = db.result31.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("details", "result31", new { id = result.id });
                    }
                    catch (Exception ex)
                    {
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                case "6th":
                    try
                    {
                        result32 result = db.result32.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("details", "result32", new { id = result.id });
                    }
                    catch (Exception ex)
                    {
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                case "7th":
                    try
                    {
                        result41 result = db.result41.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("details", "result41", new { id = result.id });
                    }
                    catch (Exception ex)
                    {
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                case "8th":
                    try
                    {
                        result42 result = db.result42.Where(x => x.examterm == ExamTerm).FirstOrDefault();
                        return RedirectToAction("details", "result42", new { id = result.id });
                    }
                    catch (Exception ex)
                    {
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    break;

                default:
                    break;
            }
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}