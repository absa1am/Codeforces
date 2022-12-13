int.TryParse(Console.ReadLine(), out int t);
int[] denominatior = {1, 10, 100, 1000, 10000, 100000};

for(int i = 0; i < t; i++)
{
    string n = Console.ReadLine();
    Console.WriteLine((int.Parse(n) / denominatior[n.Length - 1]) + (9 * (n.Length - 1)));
}