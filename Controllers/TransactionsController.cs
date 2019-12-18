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
    }
}
