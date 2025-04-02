namespace MulkFit.Models
{
    public class Aluno
    {
        int AlunoID { get; set; }
        int PersonalID { get; set; }
        string NomeAluno { get; set; }
        DateTime DataNascimento { get; set; }
        string Email { get; set; }
        string Instagram { get; set; }
        string Telefone { get; set; }
        string Observacoes { get; set; }

    }
}
// (AlunoID, NomeAluno, DataNascimento, Email, Instagram, Telefone, PersonalID, Observacoes)