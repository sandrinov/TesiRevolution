using AppointmentManagerBackEnd.Data;
using AppointmentsManagerShared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentManagerBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        private CallManagerDbContext db;

        public CallsController(CallManagerDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.db.Calls.Select(x => new Call() {
                Id = x.Id,
                Name = x.Name,
                Date = x.Date,
                Provider = x.Provider,
                Description = x.Description,
                Note = x.Note
            }).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = this.db.Calls
                .Where(x=>x.Id == id)
                .Select(x => new Call()
            {
                Id = x.Id,
                Name = x.Name,
                Date = x.Date,
                Provider = x.Provider,
                Description = x.Description,
                Note = x.Note
            }).SingleOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(Call item)
        {
            if(ModelState.IsValid)
            {
                var entity = new Call()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Date = item.Date,
                    Provider = item.Provider,
                    Description = item.Description,
                    Note = item.Note
                };

                this.db.Calls.Add(entity);
                this.db.SaveChanges();
                item.Id = entity.Id;
                return CreatedAtAction(nameof(Get), new { id = entity.Id }, item);

            }
            return BadRequest(ModelState);
        }

    }
}
