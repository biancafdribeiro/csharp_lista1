using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class TestaFuncionario
    {
        public static void MetodoFuncionario() /*o método aqui precisa ser public para que 
                                             possamos chamá-lo na Main*/
        {
            //ex 4. criar uma classe TestaFuncionario e dois objetos da classe Funcionario
            Funcionario objetofuncionario = new Funcionario();
            objetofuncionario.nome = "João";
            objetofuncionario.cargo = "Assistente administrativo";

            /*Console.WriteLine(objetofuncionario.nome);
            Console.WriteLine(objetofuncionario.cargo);*/

            //ex 10. testar os métodos do objeto da classe Funcionário
            double novoSalario = objetofuncionario.AumentarSalario(objetofuncionario.salario);
            /*chama o método AumentarSalario do objetofuncionario. é atribuido à nova variável criada, 
            novoSalario, o valor retornado pelo método. ele usa objetofuncionario.salario como argumento 
            pois o método na classe Funcionario também usa parâmetro.*/

            Console.WriteLine($"Seu novo salário é: {novoSalario}"); //$ = string interpolada

            Funcionario.ConsultarDados(objetofuncionario ); //testando o método


        }
    }
}

