int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string[] parts;
    Dictionary<int, int> n = new();

    parts = Console.ReadLine().Split(' ');

    int.TryParse(parts[0], out int m);
    int.TryParse(parts[1], out int s);

    parts = Console.ReadLine().Split(' ');

    int max = 0;
    for(int j = 0; j < parts.Length; j++)
    {
        int x = int.Parse(parts[j]);
        if(x > max) max = x;
        n.Add(x, 1);
    }

    int S = 0;
    for(int j = 1; j <= max; j++)
        if(!n.ContainsKey(j)) S += j;

    if(S == s) Console.WriteLine("YES");
    else if(S > s) Console.WriteLine("NO");
    else
    {
        int k = max + 1;
        while(S + k <= s)
        {
            S += k;
            k++;
        }

        if(S == s) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}