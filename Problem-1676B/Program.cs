int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] candies = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    long ans = 0;
    int min = candies.Min();
    for(int j = 0; j < n; j++)
        ans += candies[j] - min;
    
    Console.WriteLine(ans);
}