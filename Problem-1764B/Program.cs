int.TryParse(Console.ReadLine(), out int t);

for(int j = 0; j < t; j++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string[] inputs = Console.ReadLine().Split(' ');

    int max = 0;
    for(int i = 0; i < n; i++)
        if(max < int.Parse(inputs[i])) max = int.Parse(inputs[i]);
    
    int gcd = 0;
    for(int i = 0; i < n; i++)
        gcd = GCD(int.Parse(inputs[i]), gcd);

    Console.WriteLine(max / gcd);
}

int GCD(int a, int b)
{
    if(b == 0) return a;
    return GCD(b, a % b);
}