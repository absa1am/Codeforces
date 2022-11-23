int.TryParse(Console.ReadLine(), out int n);
string[] percent = Console.ReadLine().Split(' ');

double volume = 0.0;
for(int i = 0; i < n; i++)
    volume += double.Parse(percent[i]);

Console.WriteLine("{0:N12}", volume * (1.0 / n));