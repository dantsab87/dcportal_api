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
    [RoutePrefix("Api/Households")]
    public class HouseholdsController : ApiController
    {
        private ApiContext db = new ApiContext();
        [Route("GetAllHouseholdData")]
        public async Task<List<Household>> GetAllHouseholdData()
        {
            return await db.GetAllHouseholdData();
        }

        [Route("GetHousehold")]
        public async Task<Household> GetHousehold(int id)
        {
            return await db.GetHousehold(id);
        }
    }
}
