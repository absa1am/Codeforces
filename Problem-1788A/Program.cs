int.TryParse(Console.ReadLine(), out int t);

for (int j = 0; j < t; j++)
{
    int.TryParse(Console.ReadLine(), out int n);
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

    int two = 0;
    for (int i = 0; i < n; i++)
        if (arr[i] == 2) two++;

    if (two == 0) Console.WriteLine("1");
    else if (two % 2 == 1) Console.WriteLine("-1");
    else
    {
        int count = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] == 2) count++;

            if (count == two / 2)
            {
                Console.WriteLine(i + 1);
                break;
            }
        }
    }
}