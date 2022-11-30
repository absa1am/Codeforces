int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string[] query = Console.ReadLine().Split(' ');

    int.TryParse(query[0], out int a);
    int.TryParse(query[1], out int b);

    if(a % b == 0) Console.WriteLine(0);
    else if(a < b) Console.WriteLine(b - a);
    else Console.WriteLine((a / b) * b + b - a);
}