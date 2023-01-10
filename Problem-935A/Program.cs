int.TryParse(Console.ReadLine(), out int n);

int ans = 0;
for(int i = 1; i <= n / 2; i++)
    if(n % i == 0) ans++;

Console.WriteLine(ans);