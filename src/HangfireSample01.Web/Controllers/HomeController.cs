﻿using Hangfire;
using System.Web.Mvc;

namespace HangfireSample01.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      // Hangfireでjobをキューに登録
      BackgroundJob.Enqueue<MyJobsLib.ICostomJob>(x => x.Execute("Job Executed.")); // ★ここを変更
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