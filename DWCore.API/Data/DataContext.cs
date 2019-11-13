
using DWCore.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DWCore.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Event> Events { get; set; }
    }
}