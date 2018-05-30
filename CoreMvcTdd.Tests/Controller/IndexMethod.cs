using CoreMvcTDD.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CoreMvcTdd.Tests.Controller
{
    public class IndexMethod : HomeWithDIControllerTest
    {
        [Fact]
        public void TestIndex_ShouldReturnValidLoanTypesFromViewData()
        {
            var result = _homeController.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
            var loanTypes = Assert.IsAssignableFrom<IEnumerable<LoanType>>(viewResult.ViewData["LoanTypes"]);
            Assert.Equal(2, loanTypes.Count());
        }
    }
}
