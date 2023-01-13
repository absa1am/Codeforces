int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int ans = 0;

    if(ab[0] > ab[1])
    {
        if((ab[0] % 2 == 0 && ab[1] % 2 != 0) || (ab[0] % 2 != 0 && ab[1] % 2 == 0)) ans = 2;
        else ans = 1;
    }
    else if(ab[0] < ab[1])
    {
        if((ab[0] % 2 == 0 && ab[1] % 2 == 0) || (ab[0] % 2 != 0 && ab[1] % 2 != 0)) ans = 2;
        else ans = 1;
    }

    Console.WriteLine(ans);
}