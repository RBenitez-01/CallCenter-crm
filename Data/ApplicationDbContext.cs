using Microsoft.EntityFrameworkCore;
using CallCenterApi.Models;


namespace CallcenterApi.Data;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Llamada> Llamadas { get; set; }
}