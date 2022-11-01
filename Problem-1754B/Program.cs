int t = int.Parse(Console.ReadLine());

for(int j = 0; j < t; j++)
{
    int n = int.Parse(Console.ReadLine());

    int m = n / 2;
    for(int i = 1; i <= m; i++)
        Console.Write($"{i + m} {i} ");

    if(n % 2 != 0) Console.WriteLine(n);
    else Console.WriteLine();
}