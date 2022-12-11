int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string s = Console.ReadLine();

    bool notSuspicious = true;
    Dictionary<char, bool> map = new();

    map.Add(s[0], true);
    for(int j = 1; j < n; j++)
    {
        if(s[j - 1] != s[j])
        {
            if(!map.ContainsKey(s[j])) map.Add(s[j], true);
            else {
                notSuspicious = false;
                break;
            }
        }
    }

    if(notSuspicious) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}