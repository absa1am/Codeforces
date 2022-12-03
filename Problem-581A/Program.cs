string[] line = Console.ReadLine().Split(' ');

int a = int.Parse(line[0]);
int b = int.Parse(line[1]);

Console.WriteLine("{0} {1}", Math.Min(a, b), (Math.Max(a, b) - Math.Min(a, b)) / 2);