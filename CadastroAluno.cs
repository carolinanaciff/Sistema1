using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sistema1;
using System.Text.RegularExpressions;

namespace Sistema1
{
    public class CadastroAluno
    {
        private string nome, sexo1, peso1, altura1;
        private double peso, altura, imc;
        private char sexo;
        private string nascimento;
        private DateTime data = DateTime.Now;

        public CadastroAluno()
        {

        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public double Peso
        {
            set { peso = value; }
            get { return peso; }
        }

        public string Peso1
        {
            set { peso1 = value; }
            get { return peso1; }
        }

        public double Altura
        {
            set { altura = value; }
            get { return altura; }
        }

        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public string Nascimento
        {
            set { nascimento = value; }
            get { return nascimento; }
        }

        public string nomeAluno()
        {
            try
            {
                Console.WriteLine("\nDigite o nome do aluno: ");
                nome = Console.ReadLine();

                Regex r = new Regex("^[A-Za-zÀ-Üà-ü\\s]{3,30}$");

                if (r.IsMatch(nome))
                {
                    return nome;
                }
                else
                {
                    throw new Exception("Nome inválido! Digite novamente.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return nomeAluno();
            }
        }

        public char sexoAluno()
        {
            Console.WriteLine("Digite o sexo do aluno (M ou F): ");
            sexo = Convert.ToChar(Console.ReadLine());

            if ((sexo == 'f') || (sexo == 'm') || (sexo == 'F') || (sexo == 'M'))
            {
                return sexo;
            }
            else
            {
                Console.WriteLine("Valor incorreto! Digite F para FEMININO ou M para MASCULINO.");
                return sexoAluno();
            }
        }

        public string nascimentoAluno()
        {
            Console.WriteLine("Digite a data de nascimento (DD/MM/AAAA): ");
            nascimento = Console.ReadLine();

            return nascimento;
        }

        public double peso1Aluno()
        {
            try
            {
                Console.WriteLine("Digite o peso do aluno: ");
                peso1 = Console.ReadLine();

                Regex r = new Regex("^[0-9,]{2,6}$");

                if (r.IsMatch(peso1))
                {
                    peso = Convert.ToDouble(peso1);
                    return peso;
                }
                else
                {
                    throw new Exception("Peso inválido! Digite somento números e virgula.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return peso1Aluno();
            }
        }

        public double alturaAluno()
        {
            try
            {
                Console.WriteLine("Digite a altura do aluno: ");
                altura1 = Console.ReadLine();

                Regex r = new Regex("^[0-9,]{4,6}$");

                if (r.IsMatch(altura1))
                {
                    altura = Convert.ToDouble(altura1);
                    return altura;
                }
                else
                {
                    throw new Exception("Altura inválida! Digite somente números e virgula.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return alturaAluno();
            }
        }



        public void imprimaInfo()
        {
            if ((sexo == 'f') || (sexo == 'F'))
            {
                sexo1 = "Feminino";
            }
            else if ((sexo == 'm') || (sexo == 'M'))
            {
                sexo1 = "Masculino";
            }

            imc = peso / (altura * altura);

            Console.Clear();
            Console.WriteLine("\t===========================");
            Console.WriteLine("\t|   AVALIAÇÃO DE ALUNO    |");
            Console.WriteLine("\t|   {0}   |", data);
            Console.WriteLine("\t===========================");
            Console.WriteLine("\n\tNome..............: {0}", nome);
            Console.WriteLine("\tSexo..............: {0}", sexo1);
            Console.WriteLine("\tData de Nascimento: {0}", nascimento);
            Console.WriteLine("\tPeso..............: {0}kg", peso);
            Console.WriteLine("\tAltura............: {0}m", altura);
            Console.WriteLine("\tIMC...............: {0}", imc);
        }

        public void GravarTxt()
        {
            CadastroAluno c = new CadastroAluno();
            using (StreamWriter txt = new StreamWriter("C:\\Users\\carolina.naciff\\Documents\\Estudando\\AvaliaçãoTeste\\Avaliação.txt"))
            {
                txt.WriteLine("\t===========================");
                txt.WriteLine("\t|   AVALIAÇÃO DE ALUNO    |");
                txt.WriteLine("\t|   {0}   |", data);
                txt.WriteLine("\t===========================");
                txt.WriteLine("\n\tNome..............: {0}", nome);
                txt.WriteLine("\tSexo..............: {0}", sexo1);
                txt.WriteLine("\tData de Nascimento: {0}", nascimento);
                txt.WriteLine("\tPeso..............: {0}kg", peso);
                txt.WriteLine("\tAltura............: {0}m", altura);
                txt.WriteLine("\tIMC...............: {0}", imc);

            }


        }

        public void MenuFinal()
        {
            Menu m = new Menu();
            char op;
            Console.WriteLine("\nDESEJA GRAVAR AVALIAÇÃO? (S ou N)");
            op = Convert.ToChar(Console.ReadLine());

            if ((op == 's') || (op == 'S'))
            {
                GravarTxt();
                Console.Clear();
                Console.WriteLine("Arquivo gravado com sucesso!");
                Console.ReadKey();

                Console.Clear();
                m.Menu1();
            }
            else if ((op == 'n') || (op == 'N'))
            {
                Console.Clear();
                m.Menu1();
            }
            else
            {
                Console.WriteLine("Opção inválida! Digite S para SIM ou N para NÃO");
                MenuFinal();
            }
        }

    }
}
