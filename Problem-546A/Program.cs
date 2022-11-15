string[] parts = Console.ReadLine().Split(' ');

int.TryParse(parts[0], out int k);
int.TryParse(parts[1], out int n);
int.TryParse(parts[2], out int w);

int cost = k * ((w * (w + 1)) / 2);

if(cost <= n) Console.WriteLine(0);
else Console.WriteLine(cost - n);