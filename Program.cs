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

