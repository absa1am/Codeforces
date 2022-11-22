using System.Text;

int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string s = Console.ReadLine();

    int ans = s[0] - 96;
    for(int j = 1; j < s.Length; j++)
        if(s[j] - 96 > ans) ans = s[j] - 96;

    Console.WriteLine(ans);
}