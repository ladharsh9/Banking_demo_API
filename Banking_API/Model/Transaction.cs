namespace Banking_API.Model
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string Type { get; set; } // "Credit" or "Debit"
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }

      
        public Account Account { get; set; }
    }
}
