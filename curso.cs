public class Curso{
    public string nome {get; set;}
    public int duração {get; set;}
    public string area {get; set;}
    
    public List<Turma> turmas = new List<Turma>();

    public void AdcionarTurma(Turma t){
        this.turmas.Add(t);
    }
}