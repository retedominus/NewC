// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int mod = a % b;
if (mod == 0) Console.WriteLine("кратно");
else 
{
    Console.WriteLine($"не кратно, остаток {mod}");
}