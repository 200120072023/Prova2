using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Administrativo: Funcionario
    {
        public string Funcao { get; set; }  

        public Administrativo( string Funcao , string nome , int matricula , string cpf , double salario , string sexo , DateTime idade  ) :base( nome , matricula , cpf , salario , sexo , idade) 
        {

           this.Funcao = Funcao; 
        
        
        }
        public void ValorExtraa(double salario)

        {
            salario = (salario * 0.15) + salario  + 150.00;
        }
             
    }
}
