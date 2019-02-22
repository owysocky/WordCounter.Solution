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
      List<RepeatCounter> allItems = Item.GetAll();
      return View(allItems);
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
      return RedirectToAction("Index");
    }

  }
}
