/*Exercício 3 – Calculadora de Imposto de Renda (Condicional)
Leia o salário mensal.
Crie faixas fictícias, por exemplo:
até R$ 2.500 → isento
2.500 até 5.000 → 10%
acima de 5.000 → 20%
Mostre:
imposto
salário líquido*/

// Entrada

System.Console.WriteLine("Digite o seu salário mensal: ");
double salarioBrutoUsuario = Convert.ToDouble(Console.ReadLine());

// Processamento

const double desconto1 = 0.10;
const double desconto2 = 0.20;


// Saída

if (salarioBrutoUsuario > 2500 && salarioBrutoUsuario <= 5000)
{
    double imposto = salarioBrutoUsuario *  desconto1;
    double salarioLiquidoUsuario = salarioBrutoUsuario - imposto;
    System.Console.WriteLine($"O seu salário bruto é de R$ {salarioBrutoUsuario:F2} \n O seu salário líquido é de R$ {salarioLiquidoUsuario:F2} \n O imposto pago foi de R$ {imposto:F2}");
}
else if (salarioBrutoUsuario > 5000)
{
    double imposto = salarioBrutoUsuario * desconto2;
    double salarioLiquidoUsuario = salarioBrutoUsuario - imposto;
    System.Console.WriteLine($"O seu salário bruto é de R$ {salarioBrutoUsuario:F2} \n O seu salário líquido é de R$ {salarioLiquidoUsuario:F2} \n O imposto pago foi de R$ {imposto:F2}");
}
else
{
    double imposto = 0;
    double salarioLiquidoUsuario = salarioBrutoUsuario - imposto;
    System.Console.WriteLine($"O seu salário bruto é de R$ {salarioBrutoUsuario:F2} \n O seu salário líquido é de R$ {salarioLiquidoUsuario:F2} \n O imposto pago foi de R$ {imposto:F2}");
}

