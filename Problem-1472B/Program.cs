int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] weights = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int one = 0, two = 0;
    for(int j = 0; j < n; j++)
    {
        if(weights[j] == 1) one++;
        else two++;
    }

    if(two % 2 != 0) one = one - 2;
    if(one >= 0 && one % 2 == 0) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}