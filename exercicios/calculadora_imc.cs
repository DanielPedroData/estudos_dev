/*Exercício 2 – Calculadora de IMC (Condicional)
Leia:
Nome
Peso
Altura

Calcule o IMC e informe:
Abaixo do peso
Peso normal
Sobrepeso
Obesidade*/


//Entrada 

// Solicitando nome do usuário
System.Console.WriteLine("Digite o seu nome: ");
string nomeUsuario = Console.ReadLine();

// Solicitando o peso do usuário
System.Console.WriteLine("Digite o seu peso: ");
double pesoUsuario = Convert.ToDouble(Console.ReadLine());

// Solicitado a altura do usuário'
System.Console.WriteLine("Digite a sua altura: ");
double alturaUsuario = Convert.ToDouble(Console.ReadLine());


// Processamento



// Calculando o IMC do usuario

double imcUsuario = pesoUsuario / Math.Pow(alturaUsuario, 2);



// Saída

if (imcUsuario < 18.5)
{
    System.Console.WriteLine($" Olá {nomeUsuario}, seu IMC é {imcUsuario:F2} e você está abaixo do peso.");
}
else if (imcUsuario >= 18.5 && imcUsuario < 24.9)
{
    System.Console.WriteLine($" Olá {nomeUsuario}, seu IMC é {imcUsuario:F2} e você está com peso normal.");
}
else if (imcUsuario >= 25 && imcUsuario < 29.9)
{
    System.Console.WriteLine($" Olá {nomeUsuario}, seu IMC é {imcUsuario:F2} e você esta com sobrepeso.");
}
else if (imcUsuario >= 30)
{
    System.Console.WriteLine($" Olá {nomeUsuario}, seu IMC é {imcUsuario:F2} e você esta com obesidade.");
}