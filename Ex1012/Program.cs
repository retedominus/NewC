// Сортировка методом ВЫБОРА/МиниМакса НЕ РАБОТАЕТ!!
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReadArray(string a)
{
    string[] txtarray = a.Split(" ");
    int[] array = new int[txtarray.Length];
    for (int i = 0; i < txtarray.Length; i++)
    {
        array[i] = Convert.ToInt32(txtarray[i]);
    }
    return array;
}

Console.WriteLine("Введите числовой массив через пробел");
int[] main = ReadArray(Console.ReadLine());
SelectionSort(main);
PrintArray(main);
