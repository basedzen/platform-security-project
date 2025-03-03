using System.Collections.Concurrent;
using LoanApi.Models;

namespace LoanApi.Data
{
    public class LoanRepository
    {
        // Thread‑safe in‑memory store for loans.
        private readonly ConcurrentDictionary<Guid, Loan> _loans = new();

        public IEnumerable<Loan> GetAll() => _loans.Values;

        public Loan GetByLoanID(Guid loanId) =>
            _loans.TryGetValue(loanId, out var loan) ? loan : null;

        public Loan GetByBorrowerName(string borrowerName) =>
            _loans.Values.FirstOrDefault(l => l.BorrowerName.Equals(borrowerName, StringComparison.OrdinalIgnoreCase));

        public void Add(Loan loan)
        {
            loan.LoanID = Guid.NewGuid();
            _loans.TryAdd(loan.LoanID, loan);
        }

        public bool Delete(Guid loanId) => _loans.TryRemove(loanId, out _);
    }
}
