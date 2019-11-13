using System;
using System.Linq;
using System.Threading.Tasks;
using DWCore.API.Data;
using DWCore.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DWCore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly ILogger<EventController> _logger;
        private readonly DataContext _context;

        public EventController(ILogger<EventController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                var result = await _context.Events.ToListAsync();
                return Ok(result);
            }
            catch (System.Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
                //return BadRequest();
            }


        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {

            try
            {
                var result = await _context.Events.FirstOrDefaultAsync(
                    x => x.EventId == id
                );

                return Ok(result);
            }
            catch (System.Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
                //return BadRequest();
            }


        }


    }
}