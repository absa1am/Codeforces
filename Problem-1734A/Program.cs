int t = int.Parse(Console.ReadLine());

for(int j = 0; j < t; j++)
{
    int n = int.Parse(Console.ReadLine());
    string[] parts = Console.ReadLine().Split(' ');

    int[] sticks = new int[n];
    for(int i = 0; i < n; i++)
        sticks[i] = int.Parse(parts[i]);

    Array.Sort(sticks);

    int cost = (sticks[1] - sticks[0]) + (sticks[2] - sticks[1]);
    for(int i = 1; i + 2 < n; i++)
    {
        int x = (sticks[i + 1] - sticks[i]) + (sticks[i + 2] - sticks[i + 1]);
        if(x < cost) cost = x;
    }

    Console.WriteLine(cost);
}