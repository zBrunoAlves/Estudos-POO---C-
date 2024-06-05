using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_2
{
    internal class Dados_Funcionarios
    {
        public string Nome;
        public double Salario;

        public static double media_salario(double salario1, double salario2)
        {
            return (salario1 + salario2) / 2;
           
        }


    }
}
