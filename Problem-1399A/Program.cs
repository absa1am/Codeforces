int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string[] input = Console.ReadLine().Split(' ');

    int[] numbers = new int[n];
    for(int j = 0; j < n; j++)
        numbers[j] = int.Parse(input[j]);

    Array.Sort(numbers);

    int count = 0;
    for(int j = 1; j < n; j++)
        if(numbers[j] - numbers[j - 1] > 1) count++;
    
    Console.WriteLine(count == 0? "YES":"NO");
}