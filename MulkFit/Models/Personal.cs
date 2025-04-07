namespace MulkFit.Models
{
    public class Personal
    {
        public int PersonalID { get; set; }
        public string NomePersonal { get; set; }
        public string Especialidade { get; set; }

        public ICollection<Aluno> alunos { get; set; }
    }
}
//(PersonalID, NomePersonal, Especialidade)