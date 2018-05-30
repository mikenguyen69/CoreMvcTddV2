using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTDD.Web.Models
{
    public interface ILoanRepository
    {
        IEnumerable<LoanType> GetLoanTypes();
    }
}
