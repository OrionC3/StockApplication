using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using StockApplication.API.Context;
using StockApplication.API.Entities;

namespace StockApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly StockApplicationContext _context;

        public ItemController(StockApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Item item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return Ok(item);
        }
    }
}
