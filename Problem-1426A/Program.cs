int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string[] parts = Console.ReadLine().Split(' ');

    int n = int.Parse(parts[0]);
    int x = int.Parse(parts[1]);

    int sum = 2, count = 1;
    while(sum < n)
    {
        count++;
        sum += x;
    }

    Console.WriteLine(count);
}