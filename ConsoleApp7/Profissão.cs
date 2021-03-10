using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Profissão
    {
        public string profissao1() {

            string profissao;
            Idade idadefinal1 = new Idade();
            int idadefinal2 = idadefinal1.idade();

            if (idadefinal2 >= 25)
            {
                profissao = " Dev Backend";
            }
            else
            {
                profissao = "Dev Frontend";
            }
            return profissao;

        }

    }
}
