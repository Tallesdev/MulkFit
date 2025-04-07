using MulkFit.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace MulkFit.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            Context context = app.ApplicationServices.GetRequiredService<Context>();
            context.Database.Migrate();
            if (!context.alunos.Any())
            {
                context.alunos.AddRange(
                new Aluno
                {
                    NomeAluno = "Talles Gabriel",
                    DataNascimento = DateTime.ParseExact("14/04/2005", "dd/MM/yyyy", null),
                    Email = "Tallesg765@gmail.com",
                    Instagram = "Tallegsouza",
                    Telefone = "35999771580",
                    Observacoes = "Sou cardiaco, então não posso com exercicios aerobicos"
                }
            );
            }
            context.SaveChanges();
        }
    }
}

