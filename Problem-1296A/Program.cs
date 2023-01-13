int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] elements = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int odd, even, sum;

    odd = even = sum = 0;
    for(int j = 0; j < n; j++)
    {
        sum += elements[j];
        if(elements[j] % 2 == 0) even++;
        else odd++;
    }

    if(sum % 2 != 0 || (odd > 0 && even > 0)) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}