int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);

    int p = (int) Math.Floor((decimal) n / 3);
    int q = (int) Math.Ceiling((decimal) n / 3);

    if(p + 2 * q == n) Console.WriteLine("{0} {1}", p, q);
    else Console.WriteLine("{0} {1}", q, p);
}