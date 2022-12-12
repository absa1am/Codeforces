int[] strips = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
string s = Console.ReadLine();

int ans = 0;
for(int i = 0; i < s.Length; i++)
    ans += strips[s[i] - 48 - 1];

Console.WriteLine(ans);