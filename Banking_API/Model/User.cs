﻿namespace Banking_API.Model
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public  ICollection<Account>Accounts { get; set; }
}
}
