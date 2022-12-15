int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int odd = 0, minOdd, minEven;

    minOdd = minEven = int.MaxValue;
    
    for(int j = 0; j < n; j++)
    {
        int count = 0, x = numbers[j];

        if(x % 2 != 0)
        {
            odd++;
            while(x % 2 != 0)
            {
                x /= 2;
                count++;
            }

            if(count < minOdd) minOdd = count;
        }
        else {
            while(x % 2 == 0)
            {
                x /= 2;
                count++;
            }

            if(count < minEven) minEven = count;
        }
    }
    
    if(odd % 2 == 0) Console.WriteLine(0);
    else Console.WriteLine(Math.Min(minEven, minOdd));
}