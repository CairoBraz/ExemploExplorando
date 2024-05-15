

namespace ExemploExplorando.Models
{
    public class ExemploExceção
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            try
            {
                Metodo3();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A exceção foi tratada aqui. {ex.Message}");
                Console.WriteLine($"Também posso retornar a stackTreace. {ex.StackTrace}");
            }
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção.");
        }
    }
}

