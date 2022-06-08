Console.Write("Digite seu nome: ");
var nomeDoUsuario = Console.ReadLine();

Console.Write("Digite sua idade: ");
var idadeDoUsuario = Console.ReadLine()!;

var anoAtual = 2022;

// Utilize a mensagem a seguir como base do retorno esperado:
// Olá João, você nasceu em XXXX.
var anoDoNascimento = anoAtual - int.Parse(idadeDoUsuario);
Console.Write($"Olá {nomeDoUsuario}, você nasceu em {anoDoNascimento}");

