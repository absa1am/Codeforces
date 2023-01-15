int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int s);

    int k = 9, n = 0;
    string ans = string.Empty;

    while(k > 0)
    {
        if(n + k <= s)
        {
            n += k;
            ans = k.ToString() + ans;
        }
        
        k--;
    }

    Console.WriteLine(ans);
}