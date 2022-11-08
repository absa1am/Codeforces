string[] parts;

parts = Console.ReadLine().Split(' ');

int n = int.Parse(parts[0]);
int k = int.Parse(parts[1]);

parts = Console.ReadLine().Split(' ');

int kscore = int.Parse(parts[k - 1]);

int ans = 0;
for(int i = 0; i < n; i++)
{
    int x = int.Parse(parts[i]);
    if(x > 0 && x >= kscore) ans++;
}

Console.WriteLine(ans);