// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 7;
int num3 = 23;
int mod1 = num1 % num2;
int mod2 = num1 % num3;
if ((mod1 == 0) && (mod2 == 0)) Console.WriteLine("кратно");
else 
{
    Console.WriteLine("не кратно");
}