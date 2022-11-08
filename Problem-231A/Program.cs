int.TryParse(Console.ReadLine(), out int n);

int problem = 0;
for(int i = 0; i < n; i++)
{
    string[] parts = Console.ReadLine().Split(' ');

    if(int.Parse(parts[0]) + int.Parse(parts[1]) + int.Parse(parts[2]) >= 2)
        problem++;
}

Console.WriteLine(problem);