Universidade objUniversidade = new Universidade();
objUniversidade.nome = "Up";
objUniversidade.localizacao = "Ecoville";
objUniversidade.ano_fundacao = 1990;

Console.WriteLine(objUniversidade.nome);

Curso objCurso = new Curso();
objCurso.nome = "ads";
objUniversidade.AdicionarCurso(objCurso);

objCurso = new Curso();
objCurso.nome = "bsi";
objUniversidade.AdicionarCurso(objCurso);

Console.WriteLine(objUniversidade.nome);
foreach(var curso in objUniversidade.cursos){
        Console.WriteLine(curso.nome);
}

Curso Curso = new Curso();
Turma Turma = new Turma();

Curso.nome = "ADS";
Curso.duracao = 2;

Turma.anoformacao = 2025;
Turma.turno = "Noturno";

Curso.AdicionarTurma(Turma);

Turma = new Turma();
Turma.anoformacao = 2026;
Turma.turno = "Manha";



foreach(var T in Curso.turmas){
        Console.WriteLine(T.GetHashCode());
}




