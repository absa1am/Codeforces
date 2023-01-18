int.TryParse(Console.ReadLine(), out int t);

for(int j = 0; j < t; j++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string[] parts = Console.ReadLine().Split(' ');

    int repeatedElem = -1;
    Dictionary<int, int> map = new();

    for(int i = 0; i < n; i++)
    {
        int x = int.Parse(parts[i]);

        if(map.ContainsKey(x))
        {
            map[x]++;
            if (map[x] == 3)
            {
                repeatedElem = x;
                break;
            }
        }
        else map.Add(x, 1);
    }

    Console.WriteLine(repeatedElem);
}