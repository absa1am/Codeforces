int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);

    int h = n / 2;
    long[] arr = new long[n];

    arr[0] = 2;
    for(int j = 1; j < n; j++)
        arr[j] = arr[j - 1] * 2;
    
    long pileA = arr[n - 1];
    for(int j = 0; j < h - 1; j++)
        pileA += arr[j];

    long pileB = 0;
    for(int j = n - 2; j > n - 2 - h; j--)
        pileB += arr[j];
    
    Console.WriteLine(Math.Abs(pileA - pileB));
}