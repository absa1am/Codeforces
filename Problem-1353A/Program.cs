int.TryParse(Console.ReadLine(), out int t);

for (int j = 0; j < t; j++)
{
    string[] parts = Console.ReadLine().Split(' ');

    int n = int.Parse(parts[0]);
    int m = int.Parse(parts[1]);

    if (n == 1) Console.WriteLine("0");
    else if (n == 2) Console.WriteLine(m);
    else Console.WriteLine(2 * m);
}