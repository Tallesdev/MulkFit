namespace MulkFit.Models
{
    public class Treino
    {
        int TreinoID { get; set; }
        int PersonalID { get; set; }
        int AlunoID {get; set;}
        string CategoriaTreino { get; set; }
        DateTime Data { get; set; }
        DateTime Hora { get; set; }

    }
}
//(TreinoID, PersonalID, AlunoID, CategoriaTreino, Data, Hora)