using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {
    }

    public DbSet<Tipos_Solicitudes> Tipos_Solicitudes { get; set; }
    public DbSet<Estados_Solicitudes> Estados_Solicitudes { get; set; }
    public DbSet<Tipo_Identificacion> Tipo_Identificacions { get; set; }
    public DbSet<Tipos_Usuarios> Tipos_Usuarios { get; set; }
    public DbSet<Tipos_Colaboradores> Tipos_Colaboradores { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
