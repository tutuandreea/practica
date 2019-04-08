using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class AdapostContext : DbContext
    {
        public DbSet<Animal> Animals {get; set;}
        public DbSet<Owner> Owners {get; set;}
        public DbSet<Caretaker> Caretakers {get; set;}
        public DbSet<Species> Species {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Adapost;Trusted_Connection=True;");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Owner>()
                .HasMany(p => p.Animals)
                .WithOne(a => a.Owner)
                .HasForeignKey(p => p.OwnerId);
            modelBuilder
                .Entity<Caretaker>()
                .HasMany(p => p.Animals)
                .WithOne(a => a.Caretaker)
                .HasForeignKey(p => p.CaretakerId);
            modelBuilder
                .Entity<Caretaker>()
                .HasMany(p => p.Subalterni)
                .WithOne(p => p.Boss)
                .HasForeignKey(p => p.BossId);
            modelBuilder
                .Entity<Species>()
                .HasMany(s => s.Animals)
                .WithOne(a => a.Species)
                .HasForeignKey(a => a.SpeciesId);

            modelBuilder.Entity<Owner>()
                .HasData(new Owner{OwnerId = 1, Name = "John"});

            modelBuilder.Entity<Caretaker>()
                .HasData(new Caretaker{CaretakerId = 1, Name = "Joe"},
                        new Caretaker{CaretakerId = 2, Name = "Jerry", BossId=1},
                        new Caretaker{CaretakerId = 3, Name = "Jon", BossId=1},
                        new Caretaker{CaretakerId = 4, Name = "Remus", BossId=2},
                        new Caretaker{CaretakerId = 5, Name = "Marius", BossId=2},
                        new Caretaker{CaretakerId = 6, Name = "Artem", BossId=2});

            modelBuilder.Entity<Species>()
                .HasData(new Species{SpeciesId = 1, Name = "Labrador"});

            modelBuilder.Entity<Animal>()
                .HasData(new Animal{AnimalId=1, Name = "Rex", OwnerId = 1, AdoptionDate = new DateTime(1998, 2, 12), SpeciesId = 1, CaretakerId=2,Age=Age.Old, Health = Health.Healthy });
        }
    }
}