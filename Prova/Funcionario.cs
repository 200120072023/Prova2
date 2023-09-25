

namespace Prova
{
    internal class Funcionario
    {
        public Funcionario() { }
        public string nome { get; set; }

        public int matricula { get; set; }

        public string cpf { get; set; }
        public double  salario  { get; set; }
        public string sexo  { get; set; }
        public DateTime idade { get; set; }

        public Funcionario(string nome, int matricula, string cpf, double salario, string sexo, DateTime idade)
        {
            
        }
        
    }
}
