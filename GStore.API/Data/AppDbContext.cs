using GStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

            #region Configurações das tabelas
        builder.Entity<Usuario>().ToTable("usuarios");
        builder.Entity<IdentityRole>().ToTable("perfis");
        builder.Entity<IdentityUserRole<string>>().ToTable("usuarios_perfis");
        builder.Entity<IdentityUserClaim<string>>().ToTable("usuarios_regras");
        builder.Entity<IdentityUserToken<string>>().ToTable("usuarios_tokens");
        builder.Entity<IdentityUserLogin<string>>().ToTable("usuarios_logins");
        builder.Entity<IdentityUserClaim<string>>().ToTable("perfil_regras");
            #endregion
    }
}