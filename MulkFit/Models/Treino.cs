namespace MulkFit.Models
{
    public class Treino
    {
        public int TreinoID { get; set; }
        public int PersonalID { get; set; }
        public int AlunoID {get; set;}
        public string NomeTreino { get; set; }
        public string CategoriaTreino { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }

        public ICollection<Exercicio> exercicios { get; set; }
    }
}
//(TreinoID, PersonalID, AlunoID, NomeTreino, CategoriaTreino, Data, Hora)