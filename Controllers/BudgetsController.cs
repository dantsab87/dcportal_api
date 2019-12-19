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



        /// <summary>
        /// Add a Budget
        /// </summary>
        /// <param name="hhId">Household Id</param>
        /// <param name="ownerId">Owner Id</param>
        /// <param name="name">Name of Budget</param>
        /// <returns>Create a Budget</returns>
        [HttpPost, Route("AddBudget")]
        public IHttpActionResult AddBudget(int hhId, string ownerId, string name)
        {
            return Ok(db.AddBudget(hhId, ownerId, name));
        }
    }
}
