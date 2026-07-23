
System.Console.WriteLine("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();

System.Console.WriteLine("Digite a quantidade do produto:");
int quantidade = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite o preço unitário do produto R$: ");
double precoUnitario = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("forma de pagamento: " + "\n1 - Avista" + "\n2 - Parcelado");
int opcaoPagamento = Convert.ToInt32(Console.ReadLine());

double precoTotal = quantidade * precoUnitario;

// Constante pq nao muda o valor do desconto, sempre sera 10% de desconto para pagamento a vista
const double descontoAvista = 0.10; // 10% de desconto

while (opcaoPagamento != 1 && opcaoPagamento != 2)
{
    System.Console.WriteLine("Opção inválida.");

    System.Console.WriteLine("forma de pagamento: " + "\n1 - Avista" + "\n2 - Parcelado");
    opcaoPagamento = Convert.ToInt32(Console.ReadLine());
}

// Se a opcao de pagamento for 1, aplica o desconto de 10% no preço total
if (opcaoPagamento == 1)
{
    precoTotal -= precoTotal * descontoAvista;

}

System.Console.WriteLine($" O produto {nomeProduto} com quantidade de {quantidade} tem o preco total de R$ {precoTotal:F2}");



