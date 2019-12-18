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
    [RoutePrefix("Api/Budgets")]
    public class BudgetsController : ApiController
    {
        private ApiContext db = new ApiContext();
        [Route("GetBudgets")]
        public async Task<List<Budget>> GetBudgets(int id)
        {
            return await db.GetBudgets(id);
        }

        [Route("GetBudgetDetails")]
        public async Task<Budget> GetBudgetDetails(int id)
        {
            return await db.GetBudgetDetails(id);
        }
    }
}
