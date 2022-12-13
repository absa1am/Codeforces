int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string s = Console.ReadLine();

    Dictionary<string, int> d = new();

    bool ans = false;
    for(int j = 1; j < n; j++)
    {
        string x = s[j - 1].ToString() + s[j].ToString();
        
        if(!d.ContainsKey(x)) d.Add(x, j);
        else if(d[x] < j - 1) {
            ans = true;
            break;
        }
    }

    if(ans) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}