//Поиск уникальных символов
string s = "cscvsfbvaskncbvskeckafhdayslhicjfsad";
char[] buf = new char[s.Length];
int iBuf = 0;
int i = 0;
while (i < s.Length)
{
    if (Array.IndexOf(buf, s[i]) == -1)
    {
        buf[iBuf++] = s[i];
    }
    i++;
}
Console.WriteLine(String.Join(' ', buf));
