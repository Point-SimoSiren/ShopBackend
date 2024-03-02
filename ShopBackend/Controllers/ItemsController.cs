using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBackend.Models;

namespace ShopBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        private ShopDBContext db = new ShopDBContext();

        [HttpGet]
        public ActionResult GetItems()
        {
            var Items = db.Items.ToList();
            return Ok(Items);
        }

        // Add new
        [HttpPost]
        public ActionResult AddItem([FromBody] Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return Ok("Added new Item " + item.Title);
        }

    }
}
