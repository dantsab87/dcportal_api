using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dcportal_api.Models
{
    /// <summary>
    /// The Household data model
    /// </summary>
    public class Household
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of Household
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Greeting
        /// </summary>
        public string Greeting { get; set; }
        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// Is the Household configured?
        /// </summary>
        public bool IsConfigured { get; set; }
    }

    /// <summary>
    /// The Budge data model
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// Budget Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Household Id
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// Owner Id
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Name of Budget
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Targeted Amount
        /// </summary>
        public float TargetAmount { get; set; }

        /// <summary>
        /// Created Amount
        /// </summary>
        public float CurrentAmount { get; set; }
    }

    public class BudgetItem
    {
        /// <summary>
        /// Budget Item Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Budget Id
        /// </summary>
        public int BudgetId { get; set; }

        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Budget Item Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Targeted Amount
        /// </summary>
        public float TargetAmount { get; set; }

        /// <summary>
        /// Current Amount
        /// </summary>
        public float CurrentAmount { get; set; }

    }

    /// <summary>
    /// Bank Account data model
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Bank Account Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Household Id
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// Owner Id
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Name of Bank Account
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Account Type
        /// </summary>
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Starting Balance
        /// </summary>
        public float StartingBalance { get; set; }

        /// <summary>
        /// Current Balance
        /// </summary>
        public float CurrentBalance { get; set; }

        /// <summary>
        /// Low Balance
        /// </summary>
        public float LowBalanceLevel { get; set; }
    }

    /// <summary>
    /// Transaction data model
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Transaction Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Bank Account Id
        /// </summary>
        public int BankAccountId { get; set; }

        /// <summary>
        /// Budget Id
        /// </summary>
        public int? BudgetItemId { get; set; }

        /// <summary>
        /// Owner Id
        /// </summary>
        public string OwnerId { get; set; }
        
        /// <summary>
        /// Transaction Type
        /// </summary>
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Memo
        /// </summary>
        public string Memo { get; set; }

    }

    /// <summary>
    /// Transaction Type
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Deposit
        /// </summary>
        Deposit,
        /// <summary>
        /// Withdrawal
        /// </summary>
        Withdrawl
    }

    /// <summary>
    /// Account Type
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Checking
        /// </summary>
        Checkings,

        /// <summary>
        /// Savings
        /// </summary>
        Savings
    }
}