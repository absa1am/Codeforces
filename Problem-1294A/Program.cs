int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
    int max = Math.Max(Math.Max(inputs[0], inputs[1]), inputs[2]);

    for(int j = 0; j < 3; j++)
    {
        if(inputs[j] < max)
        {
            inputs[3] = inputs[3] - (max - inputs[j]);
            inputs[j] = max;
        }
    }

    if(inputs[3] < 0 || inputs[3] % 3 != 0) Console.WriteLine("NO");
    else Console.WriteLine("YES");
}