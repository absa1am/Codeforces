int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string s = Console.ReadLine();

    int a, b, c;

    a = b = c = 0;
    foreach(char ch in s)
    {
        if(ch == 'A') a++;
        else if(ch == 'B') b++;
        else c++;
    }

    if(a > b)
    {
        a = a - b;
        b = 0;
    }
    else
    {
        b = b - a;
        a = 0;
    }

    if(c > b)
    {
        c = c - b;
        b = 0;
    }
    else
    {
        b = b - c;
        c = 0;
    }

    if(a == 0 && b == 0 && c == 0) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}