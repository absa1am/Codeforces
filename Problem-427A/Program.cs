int.TryParse(Console.ReadLine(), out int n);
string[] line = Console.ReadLine().Split(' ');

int untreated = 0;
int policeMember = 0;
for(int i = 0; i < n; i++)
{
    int x = int.Parse(line[i]);

    if(x >= 0) policeMember += x;
    else if(policeMember + x >= 0) policeMember--;
    else untreated++;
}

Console.WriteLine(untreated);