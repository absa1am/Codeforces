int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    Array.Sort(numbers);

    bool duplicateFound = false;
    for(int j = 1; j < n; j++)
    {
        if (numbers[j] == numbers[j - 1])
        {
            duplicateFound = true;
            break;
        }
    }

    if (duplicateFound) Console.WriteLine("NO");
    else Console.WriteLine("YES");
}