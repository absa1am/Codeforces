int.TryParse(Console.ReadLine(), out int n);
string s = Console.ReadLine();

int numberOfN = 0, numberOfZ = 0;
for(int i = 0; i < n; i++)
{
    if(s[i] == 'n') numberOfN++;
    else if(s[i] == 'z') numberOfZ++;
}

int len = numberOfN + numberOfZ;
for(int i = 0; i < len; i++)
{
    if(numberOfN > 0)
    {
        Console.Write("1 ");
        numberOfN--;
    }
    else
    {
        Console.Write("0 ");
        numberOfZ--;
    }
}

Console.WriteLine();