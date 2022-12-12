int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string x = Console.ReadLine();

    int ans = ((x[0] - 48) - 1) * 10 + ((x.Length * (x.Length + 1)) / 2);
    Console.WriteLine(ans);
}