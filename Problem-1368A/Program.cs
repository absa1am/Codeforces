int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string[] parts = Console.ReadLine().Split(' ');

    int a = int.Parse(parts[0]);
    int b = int.Parse(parts[1]);
    int n = int.Parse(parts[2]);

    int count = 0;
    while(a <= n && b <= n)
    {
        count++;
        if (a < b) a += b;
        else b += a;
    }

    Console.WriteLine(count);
}