int.TryParse(Console.ReadLine(), out int t);

int[] letters = new int[26];

for(int i = 97; i < 123; i++)
    letters[i - 97] = i;

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string s = Console.ReadLine();

    string ans = string.Empty;
    for(int j = s.Length - 1; j >= 0; j--)
    {
        if(s[j] != '0') ans = (char) letters[(s[j] - '0') - 1] + ans;
        else
        {
            int v = (s[j - 2] - '0') * 10 + (s[j - 1] - '0');
            ans = (char) letters[v - 1] + ans;
            j = j - 2;
        }
    }

    Console.WriteLine(ans);
}