int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string[] parts = Console.ReadLine().Split(' ');

    int a = 0, b = 0;
    for(int j = 0; j < n; j++)
    {
        int x = int.Parse(parts[j]);
        if(x > b)
        {
            a = b;
            b = int.Parse(parts[j]);
        }
        else if(x > a) a = x;
    }

    for(int j = 0; j < n; j++)
    {
        int x = int.Parse(parts[j]);

        if(x != b) Console.Write(x - b + " ");
        else Console.Write(x - a + " ");
    }

    Console.WriteLine();
}