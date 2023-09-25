using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Medico:Funcionario 
    {
      public string Crm { get; set; }
        public double ValorExtra { get; set; }
        public string especialidade{ get; set; }

        public Medico(string Crm, double ValorExtra, string especialidade, string nome, int matricula, string cpf, double salario, string sexo, DateTime idade)
            :base(nome, matricula, cpf, salario,sexo ,  idade)
        {
            this.Crm = Crm; 
            this.ValorExtra = ValorExtra;
            this.especialidade = especialidade;
        }
        public virtual void  Bonus (double salario)
        {
            salario = (salario * 0.20) + salario;
        }


    }
}
