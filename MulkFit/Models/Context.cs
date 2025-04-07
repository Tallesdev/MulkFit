using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MulkFit.Models;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace MulkFit.Models
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options)
              : base(options)
        {

        }
        public DbSet<Aluno> alunos { get; set; }
        public DbSet<Exercicio> exercicios { get; set; }
        public DbSet<Personal> personal { get; set; }
        public DbSet<Treino> treinos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Treino>()
                .HasMany(e => e.exercicios)
                .WithMany(t => t.treinoss)
                .UsingEntity(j => j.ToTable("TreinoExercicio"));
        }
}

        public class ContextFactory : IDesignTimeDbContextFactory<Context>
        {
            public Context CreateDbContext(string[] args)
            {
                var configurationBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json"); // Garanta que o nome do arquivo está correto e no mesmo diretório do .csproj

                var configuration = configurationBuilder.Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection"); // Use o nome correto da sua string de conexão

                var optionsBuilder = new DbContextOptionsBuilder<Context>();
                optionsBuilder.UseSqlServer(connectionString);

                return new Context(optionsBuilder.Options);
            }
        }

}

