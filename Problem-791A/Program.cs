string[] parts = Console.ReadLine().Split(' ');

int.TryParse(parts[0], out int a);
int.TryParse(parts[1], out int b);

int year = 0;
while(a <= b)
{
    a *= 3;
    b *= 2;
    year++;
}

Console.WriteLine(year);