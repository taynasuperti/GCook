using GCook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GCook.Data;
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
    }