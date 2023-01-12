int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int numberOfOdd, numberOfEven;

    numberOfOdd = numberOfEven = 0;
    for(int j = 0; j < 2 * n; j++)
    {
        if(numbers[j] % 2 == 0) numberOfEven++;
        else numberOfOdd++;
    }

    if(numberOfOdd != numberOfEven) Console.WriteLine("NO");
    else Console.WriteLine("YES");
}