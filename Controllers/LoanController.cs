using Microsoft.AspNetCore.Mvc;
using LoanApi.Models;
using LoanApi.Data;

namespace LoanApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly LoanRepository _repository = new();

        [HttpPost("add")]
        public IActionResult AddLoan([FromBody] Loan loan)
        {
            _repository.Add(loan);
            return Ok(loan);
        }

        [HttpGet("getByBorrower/{borrowerName}")]
        public IActionResult GetLoanByBorrower(string borrowerName)
        {
            var loan = _repository.GetByBorrowerName(borrowerName);
            return loan != null ? Ok(loan) : NotFound();
        }

        [HttpDelete("delete/{loanId}")]
        public IActionResult DeleteLoan(Guid loanId)
        {
            var result = _repository.Delete(loanId);
            return result ? Ok() : NotFound();
        }

        // Bonus endpoints
        [HttpGet("getByLoanId/{loanId}")]
        public IActionResult GetLoanByLoanID(Guid loanId)
        {
            var loan = _repository.GetByLoanID(loanId);
            return loan != null ? Ok(loan) : NotFound();
        }

        [HttpGet("getAll")]
        public IActionResult GetAllLoans() => Ok(_repository.GetAll());
    }
}
