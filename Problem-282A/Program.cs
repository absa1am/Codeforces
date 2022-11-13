int n = int.Parse(Console.ReadLine());

int X = 0;
for(int i = 0; i < n; i++)
{
    string cmd = Console.ReadLine();
    
    if(cmd == "++X" || cmd == "X++") X++;
    else X--;
}

Console.WriteLine(X);