using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoreMvcTdd.Tests.View
{
    public class ViewTest
    {
        [Fact]
        public void TestResultView()
        {
            var httpContext = new DefaultHttpContext();
            var modelState = new ModelStateDictionary();
            var actionContext = new ActionContext(httpContext, new Microsoft.AspNetCore.Routing.RouteData(), new PageActionDescriptor(), modelState);
            var modelMetadataProvider = new EmptyModelMetadataProvider();
            var viewData = new ViewDataDictionary(modelMetadataProvider, modelState);
            var pageContext = new PageContext(actionContext)
            {
                ViewData = viewData
            };
            var pageModel = new ResultModel
            {
                PageContext = pageContext,
                Url = new UrlHelper(actionContext)
            };
            var result = pageModel.RedirectToPage();
            Assert.IsType<RedirectToPageResult>(result);
        }
    }

    public class ResultModel : PageModel
    {
        public string Message { get; set; }
    }
}
