int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

if (inputs[0] <= Math.Min(inputs[1], inputs[2]))
    Console.WriteLine("YES");
else Console.WriteLine("NO");