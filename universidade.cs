public class Universidade{
    public string nome {get; set;}
    public string localizacao {get; set;}
    public int ano_fundacao {get; set;}
    
    public List<Curso> cursos = new List<Curso>();

    public void AdicionarCurso(Curso c){
        this.cursos.Add(c);
    }
}