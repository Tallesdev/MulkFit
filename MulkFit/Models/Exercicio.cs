using MulkFit.Models;

namespace MulkFit.Models
{
    public class Exercicio
    {
        public int ExercicioID {get; set;}
        public string NomeExercicio { get; set; }
        public string CategoriaExercicio { get; set; }
        public string DescricaoExercicio { get; set; }

        public ICollection<Treino> treinoss { get; set; }
    }
}
// (ExercicioID, NomeExercicio, CategoriaExercicio, DescricaoExercicio