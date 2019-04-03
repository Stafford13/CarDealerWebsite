using GuildCars.Data.ADO;
using GuildCars.Data.Factories;
using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Script.Serialization;

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

        [HttpPost]
        public HttpResponseMessage SearchNewVehicles(JObject searchInput)
        {
            JavaScriptSerializer jr = new JavaScriptSerializer();
            ICarRepository repo = RepoFactory.CreateCarRepo();
            var response = new HttpResponseMessage();


            try
            {
                SearchCarJsonModel searchData = jr.Deserialize<SearchCarJsonModel>(searchInput.ToString());
                var cars = repo.GetNewCarsSorted(searchData.MakeModel, searchData.MinPrice, searchData.MaxPrice, searchData.MinYear, searchData.MaxYear);
                response.Content = new StringContent(jr.Serialize(cars));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/json");
            }
            catch (Exception)
            {
                response.StatusCode = (HttpStatusCode)400;
            };
            return response;
        }
    }
}
