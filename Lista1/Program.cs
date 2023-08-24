using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class TestaAluno  //classe
    {
        static void Main(string[] args) //método
        {
            //exercício 2. criando dois objetos da classe aluno e atribuindo valores a eles
            Aluno objetoAluno = new Aluno();
            objetoAluno.nome = "Bianca";
            objetoAluno.rg = "50489765";
            Console.WriteLine(objetoAluno.nome);
            Console.WriteLine(objetoAluno.rg);

            Turma objetoturma = new Turma();
            objetoturma.periodo = "Matutino";
            objetoturma.serie = "1ª série";
            Console.WriteLine(objetoturma.periodo);
            Console.WriteLine(objetoturma.serie);

            objetoAluno.TurmaDoAluno = objetoturma; //ex 8. testando o relacionamento entre turma e aluno,
                                                    //exibindo os valores do atributo turma através do objeto
                                                    //da classe Aluno



            TestaFuncionario.MetodoFuncionario(); /*para que possamos mostrar as informações da 
                                                classe testafuncinario, é necessário chamar o método
                                                na Main*/
            TestaTurma.MetodoTurma();

            Console.ReadKey();
        }


    }
}