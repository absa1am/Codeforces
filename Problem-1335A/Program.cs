int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);

    if(n % 2 == 0) n--;

    if(n <= 2) Console.WriteLine(0);
    else Console.WriteLine(n / 2);
}