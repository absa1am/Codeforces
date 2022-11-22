int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string[] parts = Console.ReadLine().Split(' ');
    int[] arr = {int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2])};

    Array.Sort(arr);

    Console.WriteLine(arr[1]);
}