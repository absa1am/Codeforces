int.TryParse(Console.ReadLine(), out int t);

for (int j = 0; j < t; j++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] healths = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int one = 0;
    int operations = 0;
    for (int i = 0; i < n; i++)
        if (healths[i] == 1) one++;

    operations = (one % 2) + (one / 2) + n - one;
    Console.WriteLine(operations);
}