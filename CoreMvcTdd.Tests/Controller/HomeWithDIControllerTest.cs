using CoreMvcTDD.Web.Controllers;
using CoreMvcTDD.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CoreMvcTdd.Tests.Controller
{
    public class HomeWithDIControllerTest
    {
        private Mock<ILoanRepository> _loanRepository;
        protected HomeWithDIController _homeController;
        
        public HomeWithDIControllerTest()
        {
            _loanRepository = new Mock<ILoanRepository>();
            _loanRepository.Setup(x => x.GetLoanTypes()).Returns(GetLoanType());
            _homeController = new HomeWithDIController(_loanRepository.Object);
        }

        private IEnumerable<LoanType> GetLoanType()
        {
            var loanTypes = new List<LoanType>();

            loanTypes.Add(new LoanType()
            {
                Id = 1, 
                Name = "Car Loan"
            });

            loanTypes.Add(new LoanType()
            {
                Id = 2,
                Name = "House Loan"
            });

            return loanTypes;
        }              
    }
}
