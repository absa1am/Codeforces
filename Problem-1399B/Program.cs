int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);

    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
    int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    long ans = 0;
    int minA = a.Min();
    int minB = b.Min();
    for(int j = 0; j < n; j++)
    {
        if(a[j] == minA || b[j] == minB) ans += (a[j] - minA) + (b[j] - minB);
        else ans += Math.Max(a[j] - minA, b[j] - minB);
    }

    Console.WriteLine(ans);
}