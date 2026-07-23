/*Exercício 4 – Caixa Eletrônico (Repetição)

Crie um menu:

1 - Depositar
2 - Sacar
3 - Consultar saldo
4 - Sair
*/

// Entrada

// Construção do menu
System.Console.WriteLine("============================");
System.Console.WriteLine("CAIXA ELETRÔNICO");

System.Console.WriteLine("Digite a opção desejada: " + "\n1" + " - Depositar" + "\n2" + " - Sacar" + "\n3" + " - Consultar Saldo" + "\n4" + " - Sair");

System.Console.WriteLine("============================");


// Processamento

double saldo = 0;
int opcao = Convert.ToInt32(Console.ReadLine());
double valorDeposito = 0.0;
// Construcao do Loop para o menu
while (opcao != 4)
{
    
 

    if (opcao == 1 )
    {
        System.Console.WriteLine("Digite o valor que deseja depositar: ");
            valorDeposito = Convert.ToDouble(Console.ReadLine());
            
        while (valorDeposito < 0)
        {
            System.Console.WriteLine("Valor menor ou igual a zero, Digite um valor Maior que Zero");
             valorDeposito = Convert.ToDouble(Console.ReadLine());
                       
        }
        saldo += valorDeposito;   
    }

    else if (opcao == 2)
    {
        System.Console.WriteLine("Digite o valor que deseja sacar: ");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            if (valorSaque > saldo)
            {
                System.Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo -= valorSaque;
            }
    }
    else if (opcao == 3)
    {
        System.Console.WriteLine($"O seu saldo é de R$ {saldo:F2}");
    }
    else
    {
       System.Console.WriteLine("Opção inválida."); 
    }
  
    System.Console.WriteLine("============================");
    System.Console.WriteLine("CAIXA ELETRÔNICO");

    System.Console.WriteLine("Digite a opção desejada: " + "\n1" + " - Depositar" + "\n2" + " - Sacar" + "\n3" + " - Consultar Saldo" + "\n4" + " - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("============================");

}

// Saida 

System.Console.WriteLine("Obrigado por utilizar o nosso caixa eletrônico. Volte sempre!");