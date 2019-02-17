using Microsoft.EntityFrameworkCore;
using ProjAgil.Models;

namespace ProjAgil.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet <Evento> Eventos { get; set; }
    }
}