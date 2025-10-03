Console.Write("Enter your name: ");
string? userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");

Console.Write("Enter first number: ");
string? a = Console.ReadLine();
Console.Write("Enter second number: ");
string? b = Console.ReadLine();

if (int.TryParse(a, out int num1) && int.TryParse(b, out int num2))
{
    int sum = Testn8n.Math.Add(num1, num2);
    Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
}
else
{
    Console.WriteLine("Invalid input. Please enter valid integers.");
}
