using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskMaster.Controllers;
using TaskMaster.Models;

namespace TaskMaster.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        //Arrange
        HomeController controller = new HomeController();
        //Act
        var indexView = controller.Index();
        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void Index_HasCorrectedModelType_ItemList()
      {
        //Arrange
        ViewResult indexView = new HomeController().Index() as ViewResult;
        //Act
        var result = indexView.ViewData.Model;
        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Item>));
      }

  }
}
