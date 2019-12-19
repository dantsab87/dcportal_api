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
    [RoutePrefix("Api/BudgetItems")]
    public class BudgetItemsController : ApiController
    {

        private ApiContext db = new ApiContext();

        /// <summary>
        /// Get Budget Items
        /// </summary>
        /// <param name="id">Budget Item Id</param>
        /// <returns>Get Budget Items</returns>
        [Route("GetBudgetItems")]
        public async Task<List<BudgetItem>> GetBudgetItems(int id)
        {
            return await db.GetBudgetItems(id);
        }

        /// <summary>
        /// Get Budget Item Details
        /// </summary>
        /// <param name="id">Budget Item Details Id</param>
        /// <returns>Get Budget Item Details</returns>
        [Route("GetBudgetItemDetails")]
        public async Task<BudgetItem> GetBudgetItemDetails(int id)
        {
            return await db.GetBudgetItemDetails(id);
        }

        /// <summary>
        /// Add a Budget Item
        /// </summary>
        /// <param name="budgetId">Budget Id</param>
        /// <param name="name">Name of Budget Item</param>
        /// <param name="targetAmount">Target Amount</param>
        /// <param name="currentAmount">Current Amount</param>
        /// <returns>Create a Budget Item</returns>
        [HttpPost, Route("AddBudgetItem")]
        public IHttpActionResult AddBudgetItem(int budgetId, string name, float targetAmount, float currentAmount)
        {
            return Ok(db.AddBudgetItem(budgetId, name, targetAmount, currentAmount));
        }


        /// <summary>
        /// Add a Budget Item
        /// </summary>
        /// <param name="id">PK Id</param>
        /// <param name="budgetId">Budget Id</param>
        /// <param name="name">Name of Budget Item</param>
        /// <param name="targetAmount">Target Amount</param>
        /// <param name="currentAmount">Current Amount</param>
        /// <returns>Create a Budget Item</returns>
        [HttpPut, Route("UpdateBudgetItem")]
        public IHttpActionResult UpdateBudgetItem(int id, int budgetId, string name, float targetAmount, float currentAmount)
        {
            return Ok(db.UpdateBudgetItem(id, budgetId, name, targetAmount, currentAmount));
        }



        /// <summary>
        /// Delete Budget Item
        /// </summary>
        /// <param name="id">Budget Item Id</param>
        /// <returns>Delete a Budget Item</returns>
        [HttpDelete, Route("DeleteBudgetItem")]
        public IHttpActionResult DeleteBudgetItem(int id)
        {
            return Ok(db.DeleteBudgetItem(id));
        }

    }
}
