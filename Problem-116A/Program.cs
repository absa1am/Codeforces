int.TryParse(Console.ReadLine(), out int n);

int capacity = 0, ans = 0;
for(int i = 0; i < n; i++)
{
    string[] parts = Console.ReadLine().Split(' ');

    capacity = capacity + int.Parse(parts[1]) - int.Parse(parts[0]);
    ans = Math.Max(capacity, ans);
}

Console.WriteLine(ans);