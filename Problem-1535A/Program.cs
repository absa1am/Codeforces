int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    if(Math.Max(arr[0], arr[1]) < Math.Min(arr[2], arr[3]) || Math.Max(arr[2], arr[3]) < Math.Min(arr[0], arr[1]))
        Console.WriteLine("NO");
    else Console.WriteLine("YES");
}