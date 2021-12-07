using Microsoft.EntityFrameworkCore;

namespace Tacos
{
    public class TacosContext:DbContext
    {
        public DbSet<Tacos> Tacos { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        public TacosContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = "server=localhost;port=3307;database=tacos;uid=tacos;password=tacos;TreatTinyAsBoolean=false";
            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Composition>()
                .HasKey(x => new {x.IngredientId, x.TacosId})
                ;

        }
    }
}