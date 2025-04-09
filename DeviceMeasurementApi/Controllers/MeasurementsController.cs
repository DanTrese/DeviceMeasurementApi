using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeviceMeasurementApi.Models;
using System.Diagnostics.Metrics;
using DeviceMeasurementApi.Data;

namespace DeviceMeasurementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {

        private readonly MeasurementDbContext _context;

        public MeasurementsController(MeasurementDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpPost]
        public IActionResult AddMeasurement([FromBody] Measurement measurement)
        {
            _context.Measurements.Add(measurement);

            _context.SaveChanges();
            
        return CreatedAtAction(nameof(AddMeasurement), new { measurement.Id }, measurement);
        }

        [HttpGet]
        public IActionResult GetMeasurement()
        {
           return Ok(_context.Measurements.ToList());                                                     
        }

        [HttpDelete]
        public IActionResult DeleteMeasurement(int id) 
        {
            var measurement = _context.Measurements.Find(id);

            if (measurement == null)
            {
                return NotFound();
            }

            _context.Measurements.Remove(measurement);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
