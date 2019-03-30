using GuildCars.Data.ADO;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GuildCars.Controllers
{
    public class APIController : ApiController
    {
        [Route("api/inventory/search/{type}/{term}/{minPrice}/{maxPrice}/{minYear}/{maxYear}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult Search(string type, string term, decimal minPrice, decimal maxPrice, int minYear, int maxYear)
        {
            CarRepositoryADO repo = new CarRepositoryADO();
            IEnumerable<Car> found = repo.Search(type, term, minPrice, maxPrice, minYear, maxYear);

            if (found == null)
            {
                return NotFound();
            }

            return Ok(found);
        }

       
    }
}
