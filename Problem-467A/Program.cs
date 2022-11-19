int.TryParse(Console.ReadLine(), out int n);

int ans = 0;
for(int i = 0; i < n; i++)
{
    string[] parts = Console.ReadLine().Split(' ');

    if(int.Parse(parts[0]) + 2 <= int.Parse(parts[1]))
        ans++;
}

Console.WriteLine(ans);