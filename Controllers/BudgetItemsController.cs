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
        [Route("GetBudgetItems")]
        public async Task<List<BudgetItem>> GetBudgetItems(int id)
        {
            return await db.GetBudgetItems(id);
        }

        [Route("GetBudgetItemDetails")]
        public async Task<BudgetItem> GetBudgetItemDetails(int id)
        {
            return await db.GetBudgetItemDetails(id);
        }
    }
}
