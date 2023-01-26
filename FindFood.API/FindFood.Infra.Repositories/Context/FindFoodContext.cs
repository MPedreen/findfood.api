using FindFood.Domain.Usuarios;
using FindFood.Models.Models.Categorias;
using FindFood.Models.Models.Estabelecimentos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FindFood.Infra.Repositories.Context
{
    public class FindFoodContext : IdentityDbContext
    {
        public FindFoodContext(DbContextOptions options) : base(options){}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(FindFoodContext).Assembly);
        }
    }
}
