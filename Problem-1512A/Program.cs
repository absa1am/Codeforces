int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    for(int j = 3; j <= n; j++)
    {
        if(numbers[j - 3] != numbers[j - 2] && numbers[j - 2] == numbers[j - 1])
        {
            Console.WriteLine(j - 2);
            break;
        }
        else if(numbers[j - 3] != numbers[j - 2] && numbers[j - 3] == numbers[j - 1])
        {
            Console.WriteLine(j - 1);
            break;
        }
        else if(numbers[j - 3] == numbers[j - 2] && numbers[j - 2] != numbers[j - 1])
        {
            Console.WriteLine(j);
            break;
        }
    }
}