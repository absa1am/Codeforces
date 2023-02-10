int.TryParse(Console.ReadLine(), out int n);
string diskState = Console.ReadLine();
string diskOpenPass = Console.ReadLine();

int moves = 0;
for(int i = 0; i < n; i++)
{
    int a = diskState[i] - '0';
    int b = diskOpenPass[i] - '0';
    moves += Math.Min(Math.Abs(a - b), 9 - Math.Max(a, b) + Math.Min(a, b) + 1);
}

Console.WriteLine(moves);