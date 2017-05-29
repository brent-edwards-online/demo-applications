namespace DataAccess.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RecipeDbContext : DbContext
    {
        public RecipeDbContext()
            : base("name=RecipeDbContext")
        {
        }

        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .Property(e => e.name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Instruction>()
                .Property(e => e.description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Ingredients)
                .WithRequired(e => e.Recipe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Instructions)
                .WithRequired(e => e.Recipe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.unit1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Ingredients)
                .WithRequired(e => e.Unit1)
                .HasForeignKey(e => e.unit)
                .WillCascadeOnDelete(false);
        }
    }
}
