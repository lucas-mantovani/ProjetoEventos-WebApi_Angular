using Microsoft.EntityFrameworkCore;

namespace Eventos.API.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Evento> Eventos { get; set; }
    }
}