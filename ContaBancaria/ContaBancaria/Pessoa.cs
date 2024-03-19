using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public char Sexo { get; set; }


        public void fazerAniversario()
        {
            Idade++;
        }

        public void mudarSexo()
        {
            if (Sexo == 'M')
            {
                Sexo = 'F';
            }
            else
            {
                Sexo = 'M';
            }
        }

    }
}
