int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    if((nm[0] * nm[1]) % 2 == 0) Console.WriteLine((nm[0] * nm[1]) / 2);
    else Console.WriteLine(((nm[0] * nm[1]) / 2) + 1);
}