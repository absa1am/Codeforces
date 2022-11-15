int.TryParse(Console.ReadLine(), out int x);

int steps = 0;
for(int i = 5; i > 0; i--)
{
    steps += x / i;
    x %= i;
}

Console.WriteLine(steps);