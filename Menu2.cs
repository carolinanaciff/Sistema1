using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema1;

namespace Sistema1
{
    class Menu2
    {
        public void menuINT()
        {

            Menu mn = new Menu();

            Console.WriteLine("MENU");
            Console.WriteLine("(1) CONTINUAR CADASTRO");
            Console.WriteLine("(2) VOLTAR AO MENU ANTERIOR");

            ConsoleKeyInfo menuSelecao;
            menuSelecao = Console.ReadKey(true);

            switch(menuSelecao.KeyChar)
            {
                case '1':
                    Console.Clear();
                    break;
                case '2':
                    Console.Clear();
                    mn.Menu1();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.ReadKey();
                    Console.Clear();
                    menuINT();
                    break;
            }

        }
    }
}
