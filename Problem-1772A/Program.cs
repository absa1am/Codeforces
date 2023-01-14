int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string exp = Console.ReadLine();

    Console.WriteLine((exp[0] - '0') + (exp[2] - '0'));
}