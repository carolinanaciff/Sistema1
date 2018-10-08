using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sistema1;

namespace Sistema1
{
    class Menu
    {
         public void Menu1(){

            CadastroAluno c = new CadastroAluno();
            Menu2 m = new Menu2();
            string nome;
            string nascimento;
            double peso, altura, imc;
            char sexo;

            Console.WriteLine("===========================");
            Console.WriteLine("|   AVALIAÇÃO DE ALUNOS   |");
            Console.WriteLine("===========================");
            Console.WriteLine("\nMENU: ");
            Console.WriteLine("(1) CADASTRO DE NOVO ALUNO");
            Console.WriteLine("(2) CONSULTAR ALUNO CADASTRADO");
            Console.WriteLine("(3) SAIR");

            ConsoleKeyInfo menuSelecao;
            menuSelecao = Console.ReadKey(true);

            switch (menuSelecao.KeyChar)
            {
                case '1':
                    Console.Clear();
                    m.menuINT();
                    nome = c.nomeAluno();
                    sexo = c.sexoAluno();
                    nascimento = c.nascimentoAluno();
                    altura = c.alturaAluno();
                    peso = c.peso1Aluno();
                    c.imprimaInfo();
                    c.MenuFinal();
                    Console.ReadKey();
                    Console.Clear();
                    Menu1();
                    break;
                case '2':
                    Console.WriteLine("Opção 2");
                    Console.ReadKey();
                    break;
                case '3':
                    Console.WriteLine("\nSAINDO DO SISTEMA.");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu1();
                    break;
            }
            }
        
    }
    }
