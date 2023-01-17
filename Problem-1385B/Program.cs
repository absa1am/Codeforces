int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] mergedPermutation = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    HashSet<int> restoredPermutation = new HashSet<int>();

    for(int j = 0; j < 2 * n; j++)
        restoredPermutation.Add(mergedPermutation[j]);

    Console.WriteLine(string.Join(' ', restoredPermutation.ToArray()));
}