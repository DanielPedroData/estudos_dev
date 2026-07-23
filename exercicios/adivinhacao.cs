/*Exercício 5 – Jogo de Adivinhação (Repetição)
O computador possui um número fixo (por exemplo 37).

O usuário tenta adivinhar.

Informe:

Maior
Menor
Acertou

Conte quantas tentativas foram necessárias.*/


var random = new Random();
int numero = random.Next(1, 101); 

int tentativas = 0;
int resposta = 0;


// Usei para validação 
System.Console.WriteLine(numero);

while(resposta != numero)
{
    // Entrada
    System.Console.WriteLine("Que numero estou pensando? Digite um numero entre 1 e 100: ");
    resposta = Convert.ToInt32(Console.ReadLine());

    /// Comparacao de respotata

        if(resposta > 0 || resposta < 100  )
        {
            System.Console.WriteLine("Numero invalido, digite novamente");
            //System.Console.WriteLine($" Tente um numero menor ");
        }
        else if(resposta < numero || resposta < 0)
        {
            System.Console.WriteLine($" Tente um numero maior");
        }
        else if(resposta > numero )
        {
            System.Console.WriteLine($" Tente um numero menor ");
            //System.Console.WriteLine("Numero invalido, digite novamente");
        }
        else
        {
            System.Console.WriteLine("Você acertou!!");
        }

        // Contagem   
        tentativas ++;
}

// Saida 
System.Console.WriteLine($"Foram {tentativas} tentativas.");