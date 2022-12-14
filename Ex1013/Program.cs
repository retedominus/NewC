// см Ex1011
//Метод ТИП 2 -> ⚙️ void
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
// или Method21(count: 4, msg: "Текст");
//Метод ТИП 3 ⚙️ -> int
int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
System.Console.WriteLine(Year);

//Метод ТИП4 -> ⚙️ ->
string Method4(int count, string text)
{
    string result = string.Empty;//или ""
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
System.Console.WriteLine(res);

//Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}x{j}={i * j}");
    }
    System.Console.WriteLine();
}

//Замена слов в тексте
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string text = "— Скажи-ка, дядя, ведь не даром "
            + "Москва, спаленная пожаром, "
            + "Французу отдана? "
            + "Ведь были ж схватки боевые, "
            + "Да, говорят, еще какие! "
            + "Недаром помнит вся Россия "
            + "Про день Бородина! ";
string newText = Replace(text, ' ', '/');
System.Console.WriteLine(newText);