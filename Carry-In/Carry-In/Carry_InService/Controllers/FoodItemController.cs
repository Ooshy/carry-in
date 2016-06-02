using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using Carry_InService.DataObjects;
using Carry_InService.Models;

namespace Carry_InService.Controllers
{
    public class FoodItemController : TableController<FoodItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            Carry_InContext context = new Carry_InContext();
            DomainManager = new EntityDomainManager<FoodItem>(context, Request);
        }

        // GET tables/FoodItem
        public IQueryable<FoodItem> GetAllFoodItems()
        {
            return Query();
        }

        // GET tables/FoodItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<FoodItem> GetFoodItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/FoodItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<FoodItem> PatchFoodItem(string id, Delta<FoodItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/FoodItem
        public async Task<IHttpActionResult> PostFoodItem(FoodItem item)
        {
            FoodItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/FoodItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteFoodItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}