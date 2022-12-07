string[] line = Console.ReadLine().Split(' ');

int.TryParse(line[0], out int k);
int.TryParse(line[1], out int r);

int ans = 1;
while((k * ans - r) % 10 != 0 && (k * ans) % 10 != 0) ans++;

Console.WriteLine(ans);