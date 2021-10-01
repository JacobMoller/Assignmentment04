using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment4.Entities
{
    public class KanbanContext : DbContext
    {
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            public KanbanContext(DbContextOptions<KanbanContext> options) : base(options) { }

            modelBuilder
                .Entity<Character>()
                .Property(e => e.State)
                .HasConversion(new EnumToStringConverter<State>());

        }
    }
}