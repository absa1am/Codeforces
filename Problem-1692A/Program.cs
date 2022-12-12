int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] distances = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int ans = 0;
    for(int j = 1; j < 4; j++)
        if(distances[j] > distances[0]) ans++;

    Console.WriteLine(ans);
}

