int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] strengths = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    Array.Sort(strengths);

    int min = int.MaxValue;
    for(int j = 1; j < n; j++)
    {
        int s = strengths[j] - strengths[j - 1];
        if(s < min) min = s;
    }

    Console.WriteLine(min);
}