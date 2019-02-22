using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class RepeatCounterController : Controller
  {

    [HttpGet("/repeatcouner")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/repeatcouner/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/repeatcouner")]
    public ActionResult Create(string word, string sentence)
    {
      RepeatCounter myCounter = new RepeatCounter(word, sentence);
      bool isValid = myCounter.IsEmpty();
      if(isValid)
      {
        return View("Index", myCounter);
      }
      else
      {
        return View();
      }

    }

  }
}
