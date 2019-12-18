using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dcportal_api.Models
{
    public class Household
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Greeting { get; set; }
        public DateTime Created { get; set; }
        public bool IsConfigured { get; set; }
    }

    public class Budget
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public float TargetAmount { get; set; }
        public float CurrentAmount { get; set; }
    }

    public class BudgetItem
    {
        public int Id { get; set; }
        public int BudgetId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public float TargetAmount { get; set; }
        public float CurrentAmount { get; set; }

    }

    public class BankAccount
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        public string OwnerId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public AccountType AccountType { get; set; }
        public float StartingBalance { get; set; }
        public float CurrentBalance { get; set; }
        public float LowBalanceLevel { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public int? BudgetItemId { get; set; }
        public string OwnerId { get; set; }

        public TransactionType TransactionType { get; set; }
        public DateTime Created { get; set; }
        public float Amount { get; set; }
        public string Memo { get; set; }

    }

    public enum TransactionType
    {
        Deposit,
        Withdrawl
    }

    public enum AccountType
    {
        Checkings,
        Savings
    }
}