int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    Dictionary<int, int> ops = new();
    int n = int.Parse(Console.ReadLine());

    for(int j = 1, k = 3 * n; j < k; j += 3)
    {
        if(j % 3 != 0)
        {
            ops.Add(j, k);
            k = k - 3;
        }
    }

    Console.WriteLine(ops.Count);
    foreach (var op in ops)
        Console.WriteLine($"{op.Key} {op.Value}");
}