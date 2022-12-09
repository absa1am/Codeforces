int.TryParse(Console.ReadLine(), out int n);
int[] citizens = Array.ConvertAll(Console.ReadLine().Split(' '), citizen => int.Parse(citizen));

int maxWelfare = citizens.Max();
int minBurleNeeded = 0;

for(int i = 0; i < n; i++)
    minBurleNeeded += maxWelfare - citizens[i];

Console.WriteLine(minBurleNeeded);