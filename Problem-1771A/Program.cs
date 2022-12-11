int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
    
    int numberOfMax = 0;
    int numberOfMin = 0;
    int max = numbers.Max();
    int min = numbers.Min();
    for(int j = 0; j < n; j++)
    {
        if(numbers[j] == min) numberOfMin++;
        if(numbers[j] == max) numberOfMax++;
    }

    if(min == max) Console.WriteLine((long) n * (long) (n - 1));
    else Console.WriteLine((long) numberOfMax * (long) numberOfMin * 2);
}