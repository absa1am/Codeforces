int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    bool isSquare = true;
    string s = Console.ReadLine();

    if(s.Length % 2 == 0)
    {
        int n = s.Length / 2;
        for(int j = 0, k = n; j < n && k < s.Length; j++, k++)
        {
            if(s[j] != s[k])
            {
                isSquare = false;
                break;
            }
        }
    }
    else isSquare = false;

    if(isSquare) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}