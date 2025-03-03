namespace LoanApi.Models
{
    public class Loan
    {
        public Guid LoanID { get; set; }
        public string BorrowerName { get; set; }
        // Optional bonus properties
        public decimal RepaymentAmount { get; set; }
        public decimal FundingAmount { get; set; }
    }
}
