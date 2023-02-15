string s = Console.ReadLine();

int move = 0;
char start = 'a';
for (int i = 0; i < s.Length; i++)
{
    int a = Math.Abs((s[i] - '0') - (start - '0'));
    int b = 26 - Math.Abs((s[i] - '0') - (start - '0'));

    start = s[i];
    move += Math.Min(a, b);
}

Console.WriteLine(move);