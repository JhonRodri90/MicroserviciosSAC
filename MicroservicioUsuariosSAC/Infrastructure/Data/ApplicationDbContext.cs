using System.Reflection;
using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {
    }

    public DbSet<Tipo_Identificacion> Tipo_Identificacions { get; set; }
    public DbSet<Usuarios> Usuarios { get; set; }
    public DbSet<Tipos_Usuarios> Tipos_Usuarios { get; set; }
    public DbSet<Tipos_Colaboradores> Tipos_Colaboradores { get; set; }
    public DbSet<Colaboradores> Colaboradores { get; set; }
    public DbSet<Login> Login { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Usuarios>()
                .HasOne(s => s.Tipo_Identificacion)
                .WithMany()
                .HasForeignKey(s => s.us_ti_id);
        builder.Entity<Usuarios>()
                .HasOne(s => s.Tipos_Usuarios)
                .WithMany()
                .HasForeignKey(s => s.us_tu_id);

        builder.Entity<Colaboradores>()
                .HasOne(s => s.Tipos_Colaboradores)  // Relación con Estados Solicitudes
                .WithMany()  // Un tipo de solicitud puede tener muchos estados
                .HasForeignKey(s => s.col_tc_id);
        builder.Entity<Colaboradores>()
                .HasOne(s => s.Tipos_Usuarios)  // Relación con Estados Solicitudes
                .WithMany()  // Un tipo de solicitud puede tener muchos estados
                .HasForeignKey(s => s.col_tu_id);
        builder.Entity<Colaboradores>()
                .HasOne(s => s.Colaborador_Lider)  // Relación con Estados Solicitudes
                .WithMany()  // Un tipo de solicitud puede tener muchos estados
                .HasForeignKey(s => s.col_col_id_lider)
                .IsRequired(false);

        builder.Entity<Login>()
                .HasOne(s => s.Colaboradores)
                .WithMany()
                .HasForeignKey(s => s.lo_co_id);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

