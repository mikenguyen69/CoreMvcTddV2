using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoreMvcTdd.Tests.Controller
{
    public class AboutMethod : HomeWithDIControllerTest
    {
        [Fact]
        public void TestAbout_ShouldReturnViewResult()
        {
            //This is to test the web hook trigger
            var result = _homeController.About();
            var viewResult = Assert.IsType<ViewResult>(result);
            
        }
    }
}
