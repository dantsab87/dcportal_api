
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Web.Http;
using dcportal_api.Models;

namespace dcportal_api.Controllers
{
    /// <summary>
    /// The Resource group for Household related data
    /// </summary>
    [RoutePrefix("Api/Households")]
    public class HouseholdsController : ApiController
    {
        /// <summary>
        /// Returns all Household data in the system
        /// </summary>
        /// <returns>List of type Household in XML format</returns>
        /// <remarks>This resource could be used to get an initial list of Households from which to dig in deeper</remarks>
        private ApiContext db = new ApiContext();
        [Route("GetAllHouseholdData")]
        public async Task<List<Household>> GetAllHouseholdData()
        {
            return await db.GetAllHouseholdData();
        }

        /// <summary>
        /// Get a specific Household by the Primary Key
        /// </summary>
        /// <param name="id">Primary Key</param>
        /// <returns>A single Household data</returns>
        [Route("GetHousehold")]
        public async Task<Household> GetHousehold(int id)
        {
            return await db.GetHousehold(id);
        }


        /// <summary>
        /// Add a Household
        /// </summary>
        /// <param name="name">Name of Household</param>
        /// <param name="greeting">Greeting for Household</param>
        /// <returns>Create a Household</returns>
        [HttpPost, Route("AddHousehold")]
        public IHttpActionResult AddHousehold(string name, string greeting)
        {
            return Ok(db.AddHousehold(name, greeting));
        }

    }
}
