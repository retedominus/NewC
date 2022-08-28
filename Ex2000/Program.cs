// Сложение одномерных матриц
int[] strToInt(string a)
{
    a = a.Replace(" ", "");

    string[] b = a.Split(",");
    int[] c = new int[b.Length];
    for (int i = 0; i < b.Length; i++)
    {
        c[i] = Convert.ToInt32(b[i]);
    }
    return c;
}

int[] SumMatrix(int[] m1, int[] m2)
{
    int[] sum = new int[m1.Length];
    for (int j = 0; j < m1.Length; j++)
    {
        sum[j] = m1[j] + m2[j];
    }
    return sum;
}

string res(int[] x)
{
    return string.Join(", ", x);
    // string y = "";
    // foreach (var n in x)
    // {
    //     y += ($"{n}, ");
    // }
    // return y;
}

bool check(int[] x, int[] y)
{
    return x.Length == y.Length;
}

Console.WriteLine("Введите первую матрицу через , : ");
int[] mat1 = strToInt(Console.ReadLine());
Console.WriteLine("Введите вторую матрицу через , : ");
int[] mat2 = strToInt(Console.ReadLine());
if(check(mat1, mat2))
{
    System.Console.WriteLine(res(SumMatrix(mat1, mat2)));
}
else System.Console.WriteLine("Матрицы имеют различную длину");
