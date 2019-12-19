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
        /// <param name="targetAmount">Target Amount</param>
        /// <param name="currentAmount">Current Amount</param>
        /// <returns>Create a Budget</returns>
        [HttpPost, Route("AddBudget")]
        public IHttpActionResult AddBudget(int hhId, string ownerId, string name, float targetAmount, float currentAmount)
        {
            return Ok(db.AddBudget(hhId, ownerId, name, targetAmount, currentAmount));
        }



        /// <summary>
        /// Update Budget
        /// </summary>
        /// <param name="id">PK Id</param>
        /// <param name="hhId">Household Id</param>
        /// <param name="ownerId">Owner Id</param>
        /// <param name="name">Name of Budget</param>
        /// <param name="targetAmount">Target Amount</param>
        /// <param name="currentAmount">Current Amount</param>
        /// <returns>Update a Budget</returns>
        [HttpPut, Route("UpdateBudget")]
        public IHttpActionResult UpdateBudget(int id, int hhId, string ownerId, string name, float targetAmount, float currentAmount)
        {
            return Ok(db.UpdateBudget(id, hhId, ownerId, name, targetAmount, currentAmount));
        }



        /// <summary>
        /// Delete a Budget
        /// </summary>
        /// <param name="id">Budget Id</param>
        /// <returns>Delete a Budget</returns>
        [HttpDelete, Route("DeleteBudget")]
        public IHttpActionResult DeleteBudget(int id)
        {
            return Ok(db.DeleteBudget(id));
        }
        
    }
}
