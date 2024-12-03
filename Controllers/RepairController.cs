

using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
   
    public class RepairController(DataContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RepairService>>> GetServices()
        {
            var services=  await context.Repairs.ToListAsync();
            return services;
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<RepairService>> GetService(int id)
        {
            var service= await context.Repairs.FindAsync(id);

            if(service==null) return NotFound("This service was not found!");

            return service;
        }
    }
}