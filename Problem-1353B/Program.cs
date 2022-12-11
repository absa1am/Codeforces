int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
    int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    Array.Sort(a);
    Array.Sort(b, (x, y) => y - x);

    int sum = 0;
    for(int j = 0; j < nk[0]; j++)
    {
        if(j < nk[1] && b[j] > a[j]) sum += b[j];
        else sum += a[j];
    }

    Console.WriteLine(sum);
}