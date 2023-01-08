int[] primes = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

int nextPrime = primes[0] + 1;
while(!IsPrime(nextPrime)) nextPrime++;

if((primes[0] == 2 && primes[1] == 3)) Console.WriteLine("YES");
else if(nextPrime == primes[1]) Console.WriteLine("YES");
else Console.WriteLine("NO");

bool IsPrime(int n)
{
    for(int i = 2; i < n; i++)
        if(n % i == 0) return false;
    
    return true;
}