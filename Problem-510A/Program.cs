string[] line = Console.ReadLine().Split(' ');
int n = int.Parse(line[0]);
int m = int.Parse(line[1]);

bool h = false;
for(int i = 1; i <= n; i++)
{
    if(i % 2 != 0) Console.Write("#");
    if(i % 2 == 0 && h) Console.Write("#");

    for(int j = 2; j <= m; j++)
    {
        if(i % 2 != 0) Console.Write("#");
        else Console.Write(".");
    }

    if(i % 2 == 0 && !h) Console.Write("#");
    if(i % 2 == 0) h = h? false:true;

    Console.WriteLine();
}