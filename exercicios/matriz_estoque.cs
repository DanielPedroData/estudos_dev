/*Exercício 8 – Matriz de Estoque (Matriz)
Objetivo

Praticar:

matriz ([,]);
for dentro de for;
acumuladores;
comparação;
organização de dados em tabela.
Enunciado

Uma loja possui um estoque organizado da seguinte forma:

3 corredores
4 prateleiras em cada corredor

Cada posição guarda a quantidade de produtos.*/


/*Exercício 8 – Matriz de Estoque (Matriz)

Uma loja possui:

3 corredores
4 prateleiras

Cada posição guarda a quantidade de produtos.

Leia todos os valores.

Depois mostre:

total do estoque
corredor com maior quantidade
prateleira com maior quantidade*/





using System.Collections.Concurrent;

int [,] estoque  =   new int [3,4];

for (int i = 0; i<estoque.Length; i++)
{
    System.Console.WriteLine($"{i+1}Digite o cod corredor: ");
    qtdProduto =  Convert.ToInt32(Console.ReadLine());
    
}

