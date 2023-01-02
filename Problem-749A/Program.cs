int.TryParse(Console.ReadLine(), out int n);

if(n % 2 == 0)
{
    int ans = n / 2;

    Console.WriteLine(ans);
    for(int i = 0; i < ans; i++)
        Console.Write(2 + " ");
    
    Console.WriteLine();
}
else
{
    int ans = (n - 3) / 2;

    Console.WriteLine(ans + 1);
    for(int i = 0; i < ans; i++)
        Console.Write(2 + " ");
    
    Console.WriteLine(3);
}