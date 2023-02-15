int.TryParse(Console.ReadLine(), out int t);

for (int j = 0; j < t; j++)
{
    int.TryParse(Console.ReadLine(), out int n);

    int[] p = new int[n];

    for (int i = n; i >= 1; i--)
        p[n - i] = i;

    if(n % 2 != 0)
    {
        int x = (n + 1) / 2;

        p[x - 1] = 1;
        p[n - 1] = x;
    }

    Console.WriteLine(string.Join(' ', p));
}