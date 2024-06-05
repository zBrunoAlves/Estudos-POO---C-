using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_2
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public static double valor_total(double preco1, int quantidade1)
        {
            return preco1 * quantidade1;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public static void cabecalho()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("           ESTOQUE");
            Console.WriteLine("=================================");
            Console.WriteLine(" ");
        }

        public static void infos(string nome1, double preco1, int quantidade1)
        {
            Console.WriteLine("Nome: " + nome1);
            Console.WriteLine("Preço: " + preco1);
            Console.WriteLine("Quantidade no estoque: " + quantidade1);

            double vt = Produto.valor_total(preco1, quantidade1);

            Console.WriteLine("Valor total no estoque: " + vt);
        }
    }
}
