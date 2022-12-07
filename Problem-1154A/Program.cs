string[] input = Console.ReadLine().Split(' ');
int[] numbers = {int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3])};

Array.Sort(numbers);

Console.WriteLine("{0} {1} {2}", numbers[3] - numbers[0], numbers[3] - numbers[1], numbers[3] - numbers[2]);