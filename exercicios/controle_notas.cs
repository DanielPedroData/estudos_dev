/*Exercício 7 – Controle de Notas (Vetor)

Objetivo

--  Praticar vetores, laços de repetição, acumuladores, contadores e estruturas condicionais.

--  Enunciado

--  Desenvolva um programa que leia as notas de 10 alunos e armazene cada nota em um vetor.

--  Após o cadastro, o programa deverá exibir:

    -   Todas as notas cadastradas;
    -   A média da turma;
    -   A maior nota;
    -   A menor nota;
    -   Quantos alunos ficaram com nota acima ou igual à média;
    -   Quantos alunos foram reprovados (nota menor que 6).
    -   Regras
    -   Utilize um vetor de double.
    -   Utilize for para leitura e processamento dos dados.
    -   Não utilize métodos prontos como Average(), Max() ou Min().*/

// declaracao              instanciacao
using System.Net.Http.Headers;

double [] alunoUm  = new double [4];

double [] alunoDois  = new double [4];

double [] alunoTres  = new double [4];

double [] alunoQuatro = new double [4];

double [] alunoCinco  = new double [4];

double [] alunoSeis  = new double [4];

double [] alunoSete  = new double [4];

double [] alunoOito  = new double [4];

double [] alunoNove  = new double [4];

double [] alunoDez  = new double [4];


System.Console.WriteLine("Escolha o aluno, para lançar a nota: ");

    System.Console.WriteLine(" \n1" + " - Bruno" + "\n2" + " - Carlos" + "\n3" + " - Daniel" +
     "\n4" + " - Esau" + "\n5" + "- Fernando" + "\n6" + "- Gabriel" + "\n7" + "- Heitor" + "\n8" + "- Igor" + "\n9" + "- Mario" + 
     "\n10" + "- Naum" + "\n0" + "- Sair" );

    int escolha = Convert.ToInt32(Console.ReadLine());


while (escolha != 0)
{
    if (escolha == 1)
    {
        for (int i = 0; i < alunoUm.Length; i++)
        {
            double nota;

            do
            {
                System.Console.WriteLine($"Nota {i + 1}: ");
                nota = Convert.ToDouble(Console.ReadLine());
                if(nota < 0 || nota > 10)
                {
                    System.Console.WriteLine("Valor inválido. Digite uma nota entre 0 e 10.");

                }
            }
            while (nota< 0 || nota > 10);
            alunoUm [i] = nota; 
        }   

    }

     else if (escolha == 2)
    {
        for (int i = 0; i < alunoDois.Length; i++)
        {
            double nota;

            do
            {
                System.Console.WriteLine($"Nota {i + 1}: ");
                nota = Convert.ToDouble(Console.ReadLine());
                if(nota < 0 || nota > 10)
                {
                    System.Console.WriteLine("Valor inválido. Digite uma nota entre 0 e 10.");

                }
            }
            while (nota< 0 || nota > 10);
            alunoDois [i] = nota; 
        }
        
           

    }

    else if (escolha == 3)
    {
        for (int i = 0; i < alunoTres.Length; i++)
        {
            double nota;

            do
            {
                System.Console.WriteLine($"Nota {i + 1}: ");
                nota = Convert.ToDouble(Console.ReadLine());
                if(nota < 0 || nota > 10)
                {
                    System.Console.WriteLine("Valor inválido. Digite uma nota entre 0 e 10.");

                }
            }
            while (nota< 0 || nota > 10);
            alunoTres [i] = nota; 
        }
        
           

    }


    System.Console.WriteLine("Escolha o aluno, para lançar a nota: ");

    System.Console.WriteLine(" \n1" + " - Bruno" + "\n2" + " - Carlos" + "\n3" + " - Daniel" +
     "\n4" + " - Esau" + "\n5" + "- Fernando" + "\n6" + "- Gabriel" + "\n7" + "- Heitor" + "\n8" + "- Igor" + "\n9" + "- Mario" + 
     "\n10" + "- Naum" + "\n0" + "- Sair" );

     escolha = Convert.ToInt32(Console.ReadLine());

    
}
System.Console.WriteLine("");
System.Console.WriteLine("Media da Truma");

// aluno 1
double mediaAlunoUm = 0;
double somaAlunoUm =0;

for (int i = 0; i < alunoUm.Length; i++)
{
     somaAlunoUm +=  alunoUm[i];

    
}

mediaAlunoUm += somaAlunoUm / alunoUm.Length;

System.Console.WriteLine($"{soma} : {mediaAlunoUm}");

// aluno 2
double mediaAlunoDois = 0;
double somaAlunoDois =0;

for (int i = 0; i < alunoDois.Length; i++)
{
     somaAlunoDois +=  alunoDois[i];

    
}

mediaAlunoDois += soma / alunoDois.Length;

System.Console.WriteLine($"{soma} : {mediaAlunoDois}");

// aluno 3
double mediaAlunoTres = 0;
double somaAlunoTres =0;

for (int i = 0; i < alunoTres.Length; i++)
{
     somaAlunoTres +=  alunoTres[i];

    
}

mediaAlunoTres += soma / somaAlunoTres.Length;

System.Console.WriteLine($"{somaAlunoTres} : {mediaAlunoTres}");

somaTotal = somaAlunoDois +somaAlunoUm + somaAlunoTres;

mediasomatotal / 3 