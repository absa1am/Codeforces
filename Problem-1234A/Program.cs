int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] goods = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int sum = goods.Sum();
    int min = goods.Min();
    int max = goods.Max();

    for(int j = min;  j <= max; j++)
    {
        if(n * j >= sum)
        {
            Console.WriteLine(j);
            break;
        }
    }
}