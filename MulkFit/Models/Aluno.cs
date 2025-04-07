using System.ComponentModel.DataAnnotations;

namespace MulkFit.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public int PersonalID { get; set; }
        public string NomeAluno { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0: dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Telefone { get; set; }
        public string Observacoes { get; set; }

        public Personal ?personal { get; set; }

        public ICollection<Treino> ?treinos { get; set; }
    }
}
// (AlunoID, NomeAluno, DataNascimento, Email, Instagram, Telefone, PersonalID, Observacoes)