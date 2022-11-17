string[] parts = Console.ReadLine().Split(' ');
char[] s = Console.ReadLine().ToArray();

int.TryParse(parts[0], out int n);
int.TryParse(parts[1], out int t);

for(int j = 0; j < t; j++)
{
    for(int i = 0; i < n - 1; i++)
    {
        if(s[i] == 'B' && s[i + 1] == 'G')
        {
            s[i] = 'G';
            s[i + 1] = 'B';
            i = i + 1;
        }
    }
}

Console.WriteLine(new string(s));