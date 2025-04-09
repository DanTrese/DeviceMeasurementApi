using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeviceMeasurementApi.Models;
using System.Diagnostics.Metrics;

namespace DeviceMeasurementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddMeasurement([FromBody] Measurement measurement)
        {
            // Here you would typically save the measurement to a database
            // For this example, we'll just return it back in the response
            return CreatedAtAction(nameof(AddMeasurement), new { measurement.Id }, measurement);
        }
    }
}
