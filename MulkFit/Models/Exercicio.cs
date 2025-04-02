using MulkFit.Models;

namespace MulkFit.Models
{
    public class Exercicio
    {
        int ExercicioID{get; set;}
        string NomeExercicio { get; set; }
        string CategoriaExercicio { get; set; }
        string DescricaoExercicio { get; set; }
    }
}
// (ExercicioID, NomeExercicio, CategoriaExercicio, DescricaoExercicio