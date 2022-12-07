int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int c = Math.Abs(int.Parse(input[0]) - int.Parse(input[1]));
    Console.WriteLine(c / 10 + (c % 10 == 0? 0:1));
}