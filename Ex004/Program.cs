﻿Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();
if (username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же Саша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}