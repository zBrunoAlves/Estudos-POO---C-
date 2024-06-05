using modulo_2;
using System.Formats.Asn1;
using System.Globalization;

/*Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();

double areaY= y.Area();

Console.WriteLine("Área de X = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else
{
    Console.WriteLine("Maior área: Y");
}*/

/*Dados_Pessoa x, y;

x = new Dados_Pessoa();
y = new Dados_Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
x.Nome = Console.ReadLine();
Console.Write("Idade: ");
x.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
y.Nome = Console.ReadLine();
Console.Write("Idade: ");
y.Idade = int.Parse(Console.ReadLine());

if (x.Idade > y.Idade)
{
    Console.WriteLine("Pessoa mais velha: " + x.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + y.Nome);
}*/

/*Dados_Funcionarios n , s;

n = new Dados_Funcionarios();
s = new Dados_Funcionarios();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
n.Nome = Console.ReadLine();
Console.Write("Salario: ");
n.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome: ");
s.Nome = Console.ReadLine();
Console.Write("Salario: ");
s.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = Dados_Funcionarios.media_salario(n.Salario, s.Salario);

Console.WriteLine("Saláro médio = " + media);*/

Produto.cabecalho();

Console.Write("Nome produto: ");

Produto n = new Produto();
Produto p = new Produto();
Produto e = new Produto();

n.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
e.Quantidade = int.Parse(Console.ReadLine());

Produto.cabecalho();

Produto.infos(n.Nome, p.Preco, e.Quantidade);

Console.WriteLine("------------------------------");
Console.WriteLine("Adicionar produto #1");
Console.WriteLine("Remover produto   #2");
Console.WriteLine("------------------------------");
int escolha = int.Parse(Console.ReadLine());
int nova_quantidade;

if (escolha == 1)
{
    Console.WriteLine("Quantos produtos deseja adicionar: ");
    nova_quantidade = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("Quantos produtos deseja remover: ");
    nova_quantidade = int.Parse(Console.ReadLine());
}

switch (escolha)
{
    case 1:

        break;

    case 2:

        break;

}
