int.TryParse(Console.ReadLine(), out int n);

if(n % 2 == 0) Console.WriteLine("4 {0}", n - 4);
else {
    for(int i = 4; i <= n; i++)
    {
        if(!IsPrime(i) && !IsPrime(n - i))
        {
            Console.WriteLine("{0} {1}", i, n - i);
            break;
        }
    }
}

bool IsPrime(int n)
{
    for(int i = 2; i <= Math.Sqrt(n); i++)
        if(n % i == 0) return false;
    
    return true;
}