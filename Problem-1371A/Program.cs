int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);

    if(n % 2 == 0) Console.WriteLine(n / 2);
    else Console.WriteLine((n + 1) / 2);
}