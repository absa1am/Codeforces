string[] line = Console.ReadLine().Split(' ');

int time = 240 - int.Parse(line[1]);
int solved = 0, n = int.Parse(line[0]);

for(int i = 1; i <= n; i++)
{
    if(5 * i <= time)
    {
        solved++;
        time = time - (5 * i);
    }
    else break;
}

Console.WriteLine(solved);