int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] time = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    Console.WriteLine((23 - time[0]) * 60 + (60 - time[1]));
}