Console.Write("Digite quantos quilometros foram percorridos: ");
var quilometrosPercorridosPeloVeiculo = Console.ReadLine();

// Utilize a mensagem a seguir como base do retorno esperado:
// Seu ve�culo percorreu um total de XXXXXX milhas.

var milhasPercorridasPeloVeiculo = int.Parse(quilometrosPercorridosPeloVeiculo) * 0.62137;
Console.WriteLine($"Seu ve�culo percorreu um total de {milhasPercorridasPeloVeiculo} milhas.");
