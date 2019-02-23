using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class ScrabbleControllerTest
  {
    [TestMethod]
    public void IndexRepeatCounter_ReturnsCorrectView_True()
    {
    ScrabbleController controller = new ScrabbleController();
    ActionResult indexView = controller.Index();
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void NewRepeatCounter_ReturnsCorrectView_True()
    {
    ScrabbleController controller = new ScrabbleController();
    ActionResult indexView = controller.Index();
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToViewResult()
    {
      ScrabbleController controller = new ScrabbleController();
      IActionResult view = controller.Create("a");
      Assert.IsInstanceOfType(view, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      ScrabbleController controller = new ScrabbleController();
      ViewResult actionResult = controller.Create("a") as ViewResult;
      string result = actionResult.ViewName;
      Assert.AreEqual(result, "Index");
    }
  }
}
