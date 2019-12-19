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
    [RoutePrefix("Api/BankAccounts")]
    public class BankAccountsController : ApiController
    {
        private ApiContext db = new ApiContext();
        [Route("GetBankAccounts")]
        public async Task<List<BankAccount>> GetBankAccounts(int id)
        {
            return await db.GetBankAccounts(id);
        }

        [Route("BankAccountDetails")]
        public async Task<BankAccount> GetBankAccountDetails(int id)
        {
            return await db.GetBankAccountDetails(id);
        }




        /// <summary>
        /// Add a Bank Account
        /// </summary>
        /// <param name="hhId">Household Id</param>
        /// <param name="ownerId">Owner Id</param>
        /// <param name="name">Name of Bank Account</param>
        /// <param name="accountType">Account Type</param>
        /// <returns>Create a Bank Account</returns>
        [HttpPost, Route("AddBankAccount")]
        public IHttpActionResult AddBankAccount(int hhId, string ownerId, string name, int accountType)
        {
            return Ok(db.AddBankAccount(hhId, ownerId, name, accountType));
        }
    }
}
