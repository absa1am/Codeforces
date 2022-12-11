int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), a => int.Parse(a));

    int even = 0, odd = 0;
    for(int j = 0; j < n; j++)
    {
        if(j % 2 == 0 && numbers[j] % 2 != 0) odd++;
        else if(j % 2 != 0 && numbers[j] % 2 == 0) even++;
    }

    if(odd != even) Console.WriteLine(-1);
    else Console.WriteLine(odd);
}