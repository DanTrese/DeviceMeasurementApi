using Microsoft.EntityFrameworkCore;
using DeviceMeasurementApi.Models;

namespace DeviceMeasurementApi.Data
{
    public class MeasurementDbContext : DbContext
    {
        public MeasurementDbContext(DbContextOptions<MeasurementDbContext> options)
            : base(options)
        {
        }

        public DbSet<Measurement> Measurements { get; set; }


    }
}
