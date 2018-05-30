using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMvcTDD.Web.Models;

namespace CoreMvcTDD.Web.Controllers
{
    public class HomeWithDIController : Controller
    {
        private ILoanRepository _loanRepository;

        public HomeWithDIController(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public IActionResult Index()
        {
            var loanTypes = _loanRepository.GetLoanTypes();
            ViewData["LoanTypes"] = loanTypes;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is my application page";

            return View();
        }
    }
}