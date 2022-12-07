string[] input = Console.ReadLine().Split(' ');
int[] points = {int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2])};

Array.Sort(points);

Console.WriteLine(points[1] - points[0] + points[2] - points[1]);