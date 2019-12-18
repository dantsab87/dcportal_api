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
    }
}
