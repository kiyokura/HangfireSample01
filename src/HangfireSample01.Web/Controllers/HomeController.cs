using Hangfire;
using System;
using System.Web.Mvc;

namespace HangfireSample01.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      // Hangfireでjobをキューに登録
      BackgroundJob.Enqueue(() => new MyJobsLib.CustomJob().Execute("Job Executed."));
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}