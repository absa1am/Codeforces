string[] sumArray = Console.ReadLine().Split('+');

Array.Sort(sumArray);
Console.WriteLine(string.Join('+', sumArray));