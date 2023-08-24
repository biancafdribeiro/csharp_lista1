using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Funcionario
    {
        //ex 3. definindo atributos para a classe Funcionario
        public string matricula;
        public string nome;
        public string cargo;
        public double salario; //ex 9. crie um atributo salário e dois métodos, um AumentarSalario e outro
                               //ConsultarDados

        public Funcionario() //construtor padrão, vai definir um valor inicial sem parâmetros
        {
            salario = 2000;
        }

        public double AumentarSalario(double salario) //ex 11. sobrecarregar o método
        {
            salario += salario * 0.1;
            return salario;
        }

        public double AumentarSalario(float salario)
        {
            return AumentarSalario((double)salario); //convertendo para double
        }

        public static void ConsultarDados(Funcionario objetofuncionario) 
        {
            //recebe um objeto da classe TestaFuncionario como parâmetro.
            Console.WriteLine($"Funcionario:{objetofuncionario.nome}, Cargo: {objetofuncionario.cargo}");
        }


    }
    
}
