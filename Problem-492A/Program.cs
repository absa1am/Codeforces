int.TryParse(Console.ReadLine(), out int n);

int sum = 1, count = 0;

while(sum <= n)
{
    count++;
    sum += ((count + 1) * (count + 2)) / 2;
}

Console.WriteLine(count);