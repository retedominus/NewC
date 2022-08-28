// Fibonacci
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}
System.Console.WriteLine();
System.Console.WriteLine(Fibonacci(9));