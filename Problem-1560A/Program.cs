List<int> numbers = new();

int k = 0;
for(int i = 1; ; i++)
{
    if(i % 3 != 0 && i % 10 != 3)
    {
        k++;
        numbers.Add(i);
        if(k == 1000) break;
    }
}

int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out k);

    Console.WriteLine(numbers[k - 1]);
}