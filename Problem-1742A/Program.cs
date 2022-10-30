int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    string[] parts = Console.ReadLine().Split(' ');

    int a = int.Parse(parts[0]);
    int b = int.Parse(parts[1]);
    int c = int.Parse(parts[2]);

    if(a + b == c || b + c == a || c + a == b) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}