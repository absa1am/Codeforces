int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    Console.WriteLine(numbers.Max() - numbers.Min());
}