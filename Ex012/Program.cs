// Удалить вторую цифру трёхзначного числа
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int a = number / 100;
int b = number % 10;
Console.WriteLine($"{a}{b}");
// string result = Convert.ToString($"{a}{b}");
// Console.WriteLine(result);