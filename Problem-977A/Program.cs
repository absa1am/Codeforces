string[] parts = Console.ReadLine().Split(' ');

int.TryParse(parts[0], out int n);
int.TryParse(parts[1], out int k);

for(int i = 0; i < k; i++)
{
    if(n % 10 != 0) n--;
    else n /= 10;
}

Console.WriteLine(n);