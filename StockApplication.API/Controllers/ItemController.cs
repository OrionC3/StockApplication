using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using StockApplication.API.Context;
using StockApplication.API.Entities;
using StockApplication.API.Models.Dtos;
using StockApplication.API.Models.Mappers;

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
        public IActionResult Add(ItemCreateDto item)
        {
            var entity = item.ToEntity();
            _context.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _context.Item
                .Include(i => i.NetworkSpec)
                .Include(i => i.HardwareSpec)
                .Select(i => i.ToDto())
                .ToList();

            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _context.Item
                .Include(i => i.NetworkSpec)
                .Include(i => i.HardwareSpec)
                .FirstOrDefault(i => i.Id == id);

            if(item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
