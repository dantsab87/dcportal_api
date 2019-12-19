using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace dcportal_api.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext()
            : base("APIConnection")
        {
        }


        public static ApiContext Create()
        {
            return new ApiContext();
        }

        public int AddHousehold(string name, string greeting)
        {
            return Database.ExecuteSqlCommand("AddHousehold @name, @greeting",
            new SqlParameter("name", name),
            new SqlParameter("greeting", greeting));
        }



        public int AddBankAccount(int hhId, string ownerId, string name, int accountType, int startBal, int currentBal, int lowBal)
        {
            return Database.ExecuteSqlCommand("AddBankAccount @hhId, @ownerId, @name, @accountType, @startBal, @currentBal, @lowBal",
            new SqlParameter("hhId", hhId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("name", name),
            new SqlParameter("accountType", accountType),
            new SqlParameter("startBal", startBal),
            new SqlParameter("currentBal", currentBal),
            new SqlParameter("lowBal", lowBal));
        }


        public int AddBudget(int hhId, string ownerId, string name, int targetAmount, int currentAmount)
        {
            return Database.ExecuteSqlCommand("AddBudget @hhId, @ownerId, @name, @targetAmount, @currentAmount",
            new SqlParameter("hhId", hhId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("name", name),
            new SqlParameter("targetAmount", targetAmount),
            new SqlParameter("currentAmount", currentAmount));
        }



        public int AddBudgetItem(int budgetId, string name, int targetAmount, int currentAmount)
        {
            return Database.ExecuteSqlCommand("AddBudgetItem @budgetId, @name, @targetAmount, @currentAmount",
            new SqlParameter("budgetId", budgetId),
            new SqlParameter("name", name),
            new SqlParameter("targetAmount", targetAmount),
            new SqlParameter("currentAmount", currentAmount));
        }


        public int AddTransaction(int bankAccId, int budgetItemId, string ownerId, int transType, float amount, string memo)
        {
            return Database.ExecuteSqlCommand("AddTransaction @bankAccId, @budgetItemId, @ownerId, @transType, @amount, @memo",
            new SqlParameter("bankAccId", bankAccId),
            new SqlParameter("budgetItemId", budgetItemId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("transType", transType),
            new SqlParameter("amount", amount),
            new SqlParameter("memo", memo));
        }





        public async Task<List<Household>> GetAllHouseholdData()
        {
            return await Database.SqlQuery<Household>("GetAllHouseholdData").ToListAsync();
        }

        public async Task<Household> GetHousehold(int id)
        {
            return await Database.SqlQuery<Household>("GetHousehold @id",
            new SqlParameter("id", id)).FirstOrDefaultAsync();
        }

        public async Task<List<BankAccount>> GetBankAccounts(int Id)
        {
            return await Database.SqlQuery<BankAccount>("GetBankAccounts @Id",
                new SqlParameter("Id", Id)).ToListAsync();
        }

        public async Task<BankAccount> GetBankAccountDetails(int Id)
        {
            return await Database.SqlQuery<BankAccount>("GetBankAccountDetails @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }


        public async Task<List<Budget>> GetBudgets(int Id)
        {
            return await Database.SqlQuery<Budget>("GetBudgets @Id",
                new SqlParameter("Id", Id)).ToListAsync();
        }

        public async Task<Budget> GetBudgetDetails(int Id)
        {
            return await Database.SqlQuery<Budget>("GetBudgetDetails @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }


        public async Task<List<BudgetItem>> GetBudgetItems(int Id)
        {
            return await Database.SqlQuery<BudgetItem>("GetBudgetItems @Id",
                new SqlParameter("Id", Id)).ToListAsync();
        }

        public async Task<BudgetItem> GetBudgetItemDetails(int Id)
        {
            return await Database.SqlQuery<BudgetItem>("GetBudgetItemDetails @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }





        public async Task<List<Transaction>> GetTransactions(int Id)
        {
            return await Database.SqlQuery<Transaction>("GetTransactions @Id",
            new SqlParameter("Id", Id)).ToListAsync();
        }

        public async Task<Transaction> GetTransactionDetails(int Id)
        {
            return await Database.SqlQuery<Transaction>("GetTransactionDetails @Id",
            new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }















        public int DeleteHousehold(int id)
        {
            return Database.ExecuteSqlCommand("DeleteHousehold @id",
            new SqlParameter("Id", id));
        }



        public int DeleteBankAccount(int id)
        {
            return Database.ExecuteSqlCommand("DeleteBankAccount @id",
            new SqlParameter("Id", id));
        }


        public int DeleteBudget(int id)
        {
            return Database.ExecuteSqlCommand("DeleteBudget @id",
            new SqlParameter("Id", id));
        }



        public int DeleteBudgetItem(int id)
        {
            return Database.ExecuteSqlCommand("DeleteBudgetItems @id",
            new SqlParameter("Id", id));
        }


        public int DeleteTransaction(int id)
        {
            return Database.ExecuteSqlCommand("DeleteTransaction @id",
            new SqlParameter("Id", id));
        }

















        public int UpdateHousehold(int id, string name, string greeting)
        {
            return Database.ExecuteSqlCommand("UpdateHousehold @id, @name, @greeting",
            new SqlParameter("id", id),
            new SqlParameter("name", name),
            new SqlParameter("greeting", greeting));
        }



        public int UpdateBankAccount(int hhId, string ownerId, string name, int accountType, int startBal, int currentBal, int lowBal)
        {
            return Database.ExecuteSqlCommand("UpdateBankAccount @hhId, @ownerId, @name, @accountType, @startBal, @currentBal, @lowBal",
            new SqlParameter("hhId", hhId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("name", name),
            new SqlParameter("accountType", accountType),
            new SqlParameter("startBal", startBal),
            new SqlParameter("currentBal", currentBal),
            new SqlParameter("lowBal", lowBal));
        }


        public int UpdateBudget(int hhId, string ownerId, string name, int targetAmount, int currentAmount)
        {
            return Database.ExecuteSqlCommand("UpdateBudget @hhId, @ownerId, @name, @targetAmount, @currentAmount",
            new SqlParameter("hhId", hhId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("name", name),
            new SqlParameter("targetAmount", targetAmount),
            new SqlParameter("currentAmount", currentAmount));
        }



        public int UpdateBudgetItem(int budgetId, string name, int targetAmount, int currentAmount)
        {
            return Database.ExecuteSqlCommand("UpdateBudgetItem @budgetId, @name, @targetAmount, @currentAmount",
            new SqlParameter("budgetId", budgetId),
            new SqlParameter("name", name),
            new SqlParameter("targetAmount", targetAmount),
            new SqlParameter("currentAmount", currentAmount));
        }


        public int UpdateTransaction(int bankAccId, int budgetItemId, string ownerId, int transType, float amount, string memo)
        {
            return Database.ExecuteSqlCommand("UpdateTransaction @bankAccId, @budgetItemId, @ownerId, @transType, @amount, @memo",
            new SqlParameter("bankAccId", bankAccId),
            new SqlParameter("budgetItemId", budgetItemId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("transType", transType),
            new SqlParameter("amount", amount),
            new SqlParameter("memo", memo));
        }
    }
}


