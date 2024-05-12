using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Maria");
// Pessoa p1 = new Pessoa();
// p1.Nome = "João";
// p1.Sobrenome = "Maria";
p1.Idade = 15;


Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "João");
// Pessoa p2 = new Pessoa();
// p2.Nome = "Maria";
// p2.Sobrenome = "João";
p2.Idade = 15;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();



















// Pessoa p1 = new Pessoa();
// p1.Nome = "Pedro";
// p1.Sobrenome = "Martins";
// p1.Idade = 30;

// p1.Apresentar();
