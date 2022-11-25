int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);

    if(n % 2 == 0)
    {
        Console.Write("1");
        for(int j = 1; j < n; j++)
            Console.Write(" " + (n + 1));
    }
    else
    {
        for(int j = 0; j < n; j++)
            Console.Write("1 ");
    }

    Console.WriteLine();
}