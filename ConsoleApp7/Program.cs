using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu
            Menu menu = new Menu();
            string menu2;

            string v = menu.Menuu();
            menu2 = v;

            //nome
            Console.WriteLine("Qual seu nome?");
            string cliente = Console.ReadLine();
            Console.Clear();

            Nome nome1 = new Nome();
            string tipodousuario;

            tipodousuario = nome1.Nome1();

            Console.WriteLine(tipodousuario + cliente);

           
            //idade
            Idade idade1 = new Idade();

            int idadedousuario = idade1.idade();

            Console.WriteLine("Idade: " + idadedousuario + "anos");

            //endereço

            Endereco endereco = new Endereco();

            string enderecodocidadao = endereco.endereco;

            Console.WriteLine("Endereço: " + enderecodocidadao);


            //profissao
            Profissão profissão = new Profissão();

            string profissaodouruario = profissão.profissao1();

            Console.WriteLine("Profissão: " + profissaodouruario);

            Console.ReadKey();

        }
        
    }
}
