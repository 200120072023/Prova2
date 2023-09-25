
using Prova;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

while (true)
{
    Console.WriteLine("Bem vindo ao sistema: \n 1- cadastrar funcionario 2- sair  ");
    ulong opcao = Convert.ToUInt64(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("digite 1 - funcionario \n 2- medico \n 3- administrativo 4 - sair ");
        int OPção = Convert.ToInt32(Console.ReadLine());


        if ((OPção == 1))
        {
            Funcionario c = new Funcionario();
            Console.WriteLine("Digite seu nome:");
            c.nome = Console.ReadLine();
            c.matricula = 1;
            Console.WriteLine("Digite sua  idade:");
            c.idade = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite sua  cpf:");
            c.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua  sexo:");
            c.sexo = Console.ReadLine();
            Console.WriteLine("Digite seu salario:");
            c.salario = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine($"seu nome é {c.nome} \n sua salario  é: {c.salario}");

        }


        else if ((OPção == 2))
        {
            Funcionario medico = new Funcionario();
            Console.WriteLine("Digite seu nome:");
            medico.nome = Console.ReadLine();
            medico.matricula = 1;
            Console.WriteLine("Digite sua  idade:");
            medico.idade = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite sua  cpf:");
            medico.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua  sexo:");
            medico.sexo = Console.ReadLine();
            Console.WriteLine("Digite seu salario:");
            medico.salario = Convert.ToDouble(Console.ReadLine());
            



        }







        else if (OPção == 3)
        {
            Funcionario Administrativo = new Funcionario();
            Console.WriteLine("Digite seu nome:");
            Administrativo.nome = Console.ReadLine();
            Administrativo.matricula = 1;
            Console.WriteLine("Digite sua  idade:");
            Administrativo.idade = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite sua  cpf:");
            Administrativo.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua  sexo:");
            Administrativo.sexo = Console.ReadLine();
            Console.WriteLine("Digite seu salario:");
            Administrativo.salario = Convert.ToDouble(Console.ReadLine());
            Administrativo.








        }
        else { Console.WriteLine("opção invalida"); }
    }



    else if (opcao == 2)
    { break; }
    else
    {
        Console.WriteLine("opção invalida!");
    }


    //Falta de Tempo , e Boa viajem 








}