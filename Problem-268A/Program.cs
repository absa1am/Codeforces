int.TryParse(Console.ReadLine(), out int n);

(int h, int g)[] teams = new (int h, int g)[n];

for(int i = 0; i < n; i++)
{
    string[] team = Console.ReadLine().Split(' ');

    teams[i].h = int.Parse(team[0]);
    teams[i].g = int.Parse(team[1]);
}

int ans = 0;
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
        if(teams[i].h == teams[j].g) ans++;
}

Console.WriteLine(ans);