int.TryParse(Console.ReadLine(), out int n);

int bills = 0;
int[] denominations = {100, 20, 10, 5, 1};

for(int i = 0; i < 5; i++)
{
    bills += n / denominations[i];
    n = n % denominations[i];
}

Console.WriteLine(bills);