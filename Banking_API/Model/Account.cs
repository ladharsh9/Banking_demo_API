namespace Banking_API.Model
{
    public class Account
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }

        public decimal Balance { get; set; }
        // Navigation Property
        public User User { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
