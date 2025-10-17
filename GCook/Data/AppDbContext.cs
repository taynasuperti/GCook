using GCook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GCook.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Ingrediente> Ingredientes { get; set; }
    public DbSet<Receita> Receitas { get; set; }
    public DbSet<ReceitaIngrediente> ReceitaIngredientes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed seed = new(builder);
        builder.Entity<ReceitaIngrediente>()
            .HasKey(ri => new { ri.ReceitaId, ri.IngredienteId });

        #region Definição dos nomes do entity
        builder.Entity<Usuario>().ToTable("Usuario");
        builder.Entity<IdentityRole>().ToTable("Perfil");
        builder.Entity<IdentityUserRole<string>>().ToTable("UsuarioPerfil");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UsuarioRegra");
        builder.Entity<IdentityUserToken<string>>().ToTable("UsuarioToken");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UsuarioLogin");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("PerfilRegra");
        #endregion
    }

}