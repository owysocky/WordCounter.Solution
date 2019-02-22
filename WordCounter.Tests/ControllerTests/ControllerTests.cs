using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class ControllerTest
  {
    [TestMethod]
    public void IndexHome_ReturnsCorrectView_True()
    {
    HomeController controller = new HomeController();
    ActionResult indexView = controller.Index();
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void IndexRepeatCounter_ReturnsCorrectView_True()
    {
    RepeatCounterController controller = new RepeatCounterController();
    ActionResult indexView = controller.Index();
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToViewResult()
    {
      RepeatCounterController controller = new RepeatCounterController();
      IActionResult view = controller.Create("a", "a");
      Assert.IsInstanceOfType(view, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      RepeatCounterController controller = new RepeatCounterController();
      ViewResult actionResult = controller.Create("a", "a") as ViewResult;
      string result = actionResult.ViewName;
      Assert.AreEqual(result, "Index");
    }

  }
}
