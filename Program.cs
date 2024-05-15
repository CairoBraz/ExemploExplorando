using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> dicionario = new Dictionary<string, string>();

dicionario.Add("MG", "Minas erais");
dicionario.Add("SP", "São Paulo");
dicionario.Add("RJ", "Rio de Janeiro");

foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
}

Console.WriteLine("Removendo um valor");

dicionario.Remove("RJ");
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
}

Console.WriteLine("Alterando um valor");

dicionario["MG"] = "Minas Gerais";
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
}

Console.WriteLine("Verificando se um valor já existe");
string chave = "MS";

if (dicionario.ContainsKey(chave))
{
    Console.WriteLine($"A chave {chave} já existe! Está atribuída ao dado {dicionario[chave]}");
}
else
{
    Console.WriteLine($"O valor não existe! É seguro adicionar a chave: {chave}");
}








// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo um item da pilha. Item removido {pilha.Pop()}");

// pilha.Push(100);
// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }


















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo da fila o item: {fila.Dequeue()}!");

// fila.Enqueue(10);

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }















//new ExemploExceção().Metodo1();


















// try
// {
//     //string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     string[] linhas = File.ReadAllLines("Arquivos2/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"DirectoryNotFound. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }



















// string dataString = "2024-12-12 00:24";

// bool suceso = DateTime.TryParseExact(dataString,
//                        "yyyy-MM-dd HH:mm",
//                        CultureInfo.InvariantCulture,
//                        DateTimeStyles.None, out DateTime data);

// if (suceso)
// {
//     Console.WriteLine($"Data convertida com sucesso! {data}");
// }
// else
// {
//     Console.WriteLine($"A data {dataString} is not valid.");
// }

















// DateTime data = DateTime.Now;
// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToString("yyyy-MM-dd HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());


// DateTime data2 = DateTime.Parse(" 20/02/1996 13:13:13");
// Console.WriteLine(data2);
// Console.WriteLine(data2.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data2.ToString("yyyy-MM-dd HH:mm"));
// Console.WriteLine(data2.ToShortDateString());
// Console.WriteLine(data2.ToShortTimeString());















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1520.50M;

// Console.WriteLine(valorMonetario.ToString("n8"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("p"));


// int numero3 = 457895;

// Console.WriteLine(numero3.ToString("##-##-#-#"));













// string numero1 = "10";
// string numero2 = "20";

// int numero1 = 10; 
// int numero2 = 20; 
// int resultado = numero1 + numero2; 

// int numero1 = 10;
// string numero2 = "20";

// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);

















// Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Maria");
// // Pessoa p1 = new Pessoa();
// // p1.Nome = "João";
// // p1.Sobrenome = "Maria";
// p1.Idade = 15;


// Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "João");
// // Pessoa p2 = new Pessoa();
// // p2.Nome = "Maria";
// // p2.Sobrenome = "João";
// p2.Idade = 15;

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAlunos();



















// Pessoa p1 = new Pessoa();
// p1.Nome = "Pedro";
// p1.Sobrenome = "Martins";
// p1.Idade = 30;

// p1.Apresentar();
