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



        public async Task<Household> AddHousehold(string name, string greeting)
        {
            return await Database.SqlQuery<Household>("AddHousehold @name, @greeting",
            new SqlParameter("name", name),
            new SqlParameter("greeting", greeting)).FirstOrDefaultAsync();
        }



        public async Task<BankAccount> AddBankAccount(int hhId, string ownerId, string name, int accountType)
        {
            return await Database.SqlQuery<BankAccount>("AddBankAccount @hhId, @ownerId, @name, @accountType",
            new SqlParameter("hhId", hhId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("name", name),
            new SqlParameter("accountType", accountType)).FirstOrDefaultAsync();
        }


        public async Task<Budget> AddBudget(int hhId, string ownerId, string name)
        {
            return await Database.SqlQuery<Budget>("AddBudget @hhId, @ownerId, @name",
            new SqlParameter("hhId", hhId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("name", name)).FirstOrDefaultAsync();
        }

        public async Task<Transaction> AddTransaction(int bankAccId, int budgetItemId, string ownerId, int transType, float amount, string memo)
        {
            return await Database.SqlQuery<Transaction>("AddTransaction @bankAccId, @budgetItemId, @ownerId, @transType, @amount, @memo",
            new SqlParameter("bankAccId", bankAccId),
            new SqlParameter("budgetItemId", budgetItemId),
            new SqlParameter("ownerId", ownerId),
            new SqlParameter("transType", transType),
            new SqlParameter("amount", amount),
            new SqlParameter("memo", memo)).FirstOrDefaultAsync();
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


    }
}


