using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using dcportal_api.Models;

namespace dcportal_api.Controllers
{
    [RoutePrefix("Api/Transactions")]
    public class TransactionsController : ApiController
    {
        private ApiContext db = new ApiContext();
        [Route("GetTransactions")]
        public async Task<List<Transaction>> GetTransactions(int id)
        {
            return await db.GetTransactions(id);
        }

        [Route("GetTransactionDetails")]
        public async Task<Transaction> GetTransactionDetails(int id)
        {
            return await db.GetTransactionDetails(id);
        }



        /// <summary>
        /// Add a Transaction
        /// </summary>
        /// <param name="bankAccId">Bank Account Id</param>
        /// <param name="budgetItemId">Budget Item Id</param>
        /// <param name="ownerId">Owner Id</param>
        /// <param name="transType">Transaction Type</param>
        /// <param name="amount">Amount</param>
        /// <param name="memo">Memo</param>
        /// <returns>Create a Transaction</returns>
        [HttpPost, Route("AddTransaction")]
        public IHttpActionResult AddTransaction(int bankAccId, int budgetItemId, string ownerId, TransactionType transType, float amount, string memo)
        {
            return Ok(db.AddTransaction(bankAccId, budgetItemId, ownerId, transType, amount, memo));
        }


        /// <summary>
        /// Update Transaction
        /// </summary>
        /// <param name="id">PK Id</param>
        /// <param name="bankAccId">Bank Account Id</param>
        /// <param name="budgetItemId">Budget Item Id</param>
        /// <param name="ownerId">Owner Id</param>
        /// <param name="transType">Transaction Type</param>
        /// <param name="amount">Amount</param>
        /// <param name="memo">Memo</param>
        /// <returns>Update a Transaction</returns>
        [HttpPut, Route("UpdateTransaction")]
        public IHttpActionResult UpdateTransaction(int id, int bankAccId, int budgetItemId, string ownerId, TransactionType transType, float amount, string memo)
        {
            return Ok(db.UpdateTransaction(id, bankAccId, budgetItemId, ownerId, transType, amount, memo));
        }


        /// <summary>
        /// Delete Transaction
        /// </summary>
        /// <param name="id">Transaction Id</param>
        /// <returns>Delete a Transaction</returns>
        [HttpDelete, Route("DeleteTransaction")]
        public IHttpActionResult DeleteTransaction(int id)
        {
            return Ok(db.DeleteTransaction(id));
        }
    }
}
