/*Exercício 3 – Vetor + cálculo

Peça 5 notas.

Depois mostre:

todas as notas;
média;
maior nota;
menor nota.

Aqui você vai usar:

for;
vetor;
acumulador;
comparação (if).*/

using System.Net.Http.Headers;

double [] notasCadastradas = new double [5];


// Recebe as notas
for (int i = 0; i<notasCadastradas.Length; i++)
{
    System.Console.WriteLine($"Digite a nota {i + 1} :");
    double nota = Convert.ToDouble(Console.ReadLine());

    notasCadastradas [i] = nota;
}

// Exibe as notas

System.Console.WriteLine("Todas as notas");

for(int i = 0; i < notasCadastradas.Length; i++)
{
    System.Console.WriteLine($"Nota {i+1}: {notasCadastradas[i]}");
}


// soma nota
double soma = 0;

for (int i = 0; i < notasCadastradas.Length; i++)
{
    soma += notasCadastradas[i];
    
}

// Media da nota 
 double mediaNota = soma / notasCadastradas.Length;

 System.Console.WriteLine($"A media é: {mediaNota}");

 // Maior nota 

double maiorNota = 0;

double menorNota = 0;

 for(int i = 0; i < notasCadastradas.Length; i++)
{
    if (notasCadastradas[i] > maiorNota)
    {
        maiorNota = notasCadastradas[i];
    }
    else if(notasCadastradas[i] < menorNota || menorNota ==0 )
    {
        menorNota = notasCadastradas[i];
    }
}


System.Console.WriteLine($"A maior nota foi: {maiorNota}");


// Menor nota



/*for (int i = 0; i < notasCadastradas.Length; i++)
{
    if(notasCadastradas[i] < menorNota || menorNota ==0 )
    {
        menorNota = notasCadastradas[i];
    }
}*/

System.Console.WriteLine($"A menor nota foi: {menorNota}");
