Console.WriteLine("*** Decomposição Decimal ***");
Console.WriteLine();

Console.Write("Escreva um número inteiro que seja até ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("999: ");
Console.ResetColor();
int numero = Convert.ToInt32(Console.ReadLine());

int restante = numero;

int unidades = restante % 10;
restante /= 10;

int dezenas = restante % 10;
restante /= 10;

int centenas = restante;

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine($"\nO número {numero} possui:");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{unidades,10} unidade(s)");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{dezenas,10} dezenas(s)");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{centenas,10} centena(s).");
Console.WriteLine();
Console.ResetColor();