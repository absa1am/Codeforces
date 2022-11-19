string[] parts;

parts = Console.ReadLine().Split(' ');

int.TryParse(parts[0], out int n);
int.TryParse(parts[1], out int h);

parts = Console.ReadLine().Split(' ');

int ans = 0;
for(int i = 0; i < n; i++)
{
    if(int.Parse(parts[i]) <= h) ans++;
    else ans += 2;
}

Console.WriteLine(ans);