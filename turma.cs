public class Turma{

        public int anoformacao {get; set;}
        public string turno {get; set;}
        public string sala {get; set;}

            public List<Estudante> estudantes = new List<Estudante>();

            public void AdicionarEstudante(Estudante e){
                this.estudantes.add(e);
            }
}