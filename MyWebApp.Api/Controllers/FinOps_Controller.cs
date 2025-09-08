using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Api.Data;
using MyWebApp.Api.Models;

namespace MyWebApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinOps_Controller : ControllerBase
    {
        private readonly AppDbContext _db;
        public FinOps_Controller(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _db.FinOps_Requests.ToListAsync());

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var p = await _db.FinOps_Requests.FindAsync(id);
            return p == null ? NotFound() : Ok(p);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FinOps_Requests FinOps_Requests)
        {
            _db.FinOps_Requests.Add(FinOps_Requests);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = FinOps_Requests.FID }, FinOps_Requests);
        }

        [HttpPut("{FID:int}")]
        public async Task<IActionResult> Update(int FID, FinOps_Requests input)
        {
            if (FID != input.FID) return BadRequest();

            var FinOps_Requests = await _db.FinOps_Requests.FindAsync(FID);
            if (FinOps_Requests == null) return NotFound();

            //FinOps_Requests.Name = input.Name;
            //FinOps_Requests.Description = input.Description;
            //FinOps_Requests.Price = input.Price;

            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{FID:int}")]
        public async Task<IActionResult> Delete(int FID)
        {
            var FinOps_Requests = await _db.FinOps_Requests.FindAsync(FID);
            if (FinOps_Requests == null) return NotFound();

            _db.FinOps_Requests.Remove(FinOps_Requests);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
