int.TryParse(Console.ReadLine(), out int n);
int[] elements = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

Array.Sort(elements);

if(n == 2) Console.WriteLine(0);
else if(elements[n - 1] - elements[1] < elements[n - 2] - elements[0])
    Console.WriteLine(elements[n - 1] - elements[1]);
else Console.WriteLine(elements[n - 2] - elements[0]);