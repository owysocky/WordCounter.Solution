using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class ScrabbleController : Controller
  {

    [HttpGet("/scrabble")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/scrabble/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/scrabble")]
    public ActionResult Create(string word)
    {
      Scrabble myCounter = new Scrabble(word);
      return View("Index", myCounter);
    }
  }
}
