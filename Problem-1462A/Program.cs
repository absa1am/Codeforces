int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    for(int j = 0, k = n - 1; j <= k; j++, k--)
    {
        Console.Write("{0} ", num[j]);
        if(j != k) Console.Write("{0} ", num[k]);
    }

    Console.WriteLine();
}