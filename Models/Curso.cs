namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº: " + count + " - " + Alunos[count].NomeCompleto;
                //string texto = $"Nº: {count} - {Alunos[count].NomeCompleto}";
                string texto = string.Format("Nº: {0} - {1}", count + 1, Alunos[count].NomeCompleto);
                Console.WriteLine(texto);
            }

            // Console.WriteLine($"Alunos do curso de {Nome}");
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine($"Aluno: {aluno.NomeCompleto}");
            // }
        }
    }
}
