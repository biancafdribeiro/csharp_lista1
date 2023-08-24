using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class TestaTurma
    {
        public static void MetodoTurma()
        {
            //ex.6 criar uma classe TestaTurma e dois objetos da classe Turma

            Turma objetoturma = new Turma();
            objetoturma.periodo = "Matutino";
            objetoturma.serie = "1ª série";
            objetoturma.sigla = "EMI";
            objetoturma.ensino = "Fundamental";

            Console.WriteLine("Informações da turma 1: "); //a partir do exercício 8, é necessário estabelecer
                                                           //um relacionamento entre alunos e turmas, então
                                                           //isso será mostrado no TestaAluno. aqui está sendo
                                                           //mostrado apenas as informações da Turma.
        }
    }
}
