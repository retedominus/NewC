// Частотный словарь
int[] arr = new int[] { 1, 0, 0, 0, 3, 1, 3, 1, 2, 3, 1, 2, 3, 2, 1, 3, 1, 2 };
int max = arr.Max();
int[] dic = new int[max + 1];
for (int i = 0; i < arr.Length; i++)
{
    dic[arr[i]]++;
}
for (int i = 0; i < dic.Length; i++)
{
    System.Console.WriteLine($"{i} {dic[i]}");
}