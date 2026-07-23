

// E

// Criamos um array que terá espaço para 10 produtos.
// O tamanho é fixo, então sempre existirão 10 posições.
string[] cadastroProduto = new string[10];


// ===============================
// CADASTRO DOS PRODUTOS
// ===============================

// O for vai percorrer todas as posições do array.
//
// int i = 0          -> começa na posição 0
// i < Length         -> continua enquanto existir posição
// i++                -> aumenta 1 posição a cada volta
for (int i = 0; i < cadastroProduto.Length; i++)
{
    Console.Write($"Digite o produto {i + 1}: ");

    // Lê o nome digitado pelo usuário
    string nomeProduto = Console.ReadLine();

    // Guarda esse nome na posição atual do array.
    //
    // Primeira volta:
    // cadastroProduto[0] = "Arroz"
    //
    // Segunda volta:
    // cadastroProduto[1] = "Feijão"
    //
    // ...
    cadastroProduto[i] = nomeProduto;
}


// ===============================
// MOSTRAR TODOS OS PRODUTOS
// ===============================

Console.WriteLine();
Console.WriteLine("Produtos cadastrados:");

for (int i = 0; i < cadastroProduto.Length; i++)
{
    Console.WriteLine($"{i + 1} - {cadastroProduto[i]}");
}


// ===============================
// QUANTIDADE
// ===============================

// Como o array foi criado com 10 posições,
// o Length sempre será 10.
Console.WriteLine();
Console.WriteLine($"Quantidade cadastrada: {cadastroProduto.Length}");


// ===============================
// PRIMEIRO PRODUTO
// ===============================

// Todo array começa na posição 0.
Console.WriteLine($"Primeiro produto: {cadastroProduto[0]}");


// ===============================
// ÚLTIMO PRODUTO
// ===============================

// O último sempre será Length - 1.
//
// Se Length = 10
//
// Índices:
//
// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9  <- último
Console.WriteLine($"Último produto: {cadastroProduto[cadastroProduto.Length - 1]}");