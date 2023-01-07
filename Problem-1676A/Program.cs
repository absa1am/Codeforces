int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string s = Console.ReadLine();

    if(Sum(s, 0, 2) == Sum(s, 3, 5)) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}

int Sum(string number, int startIndex, int endIndex)
{
    int sum = 0;
    for(int i = startIndex; i <= endIndex; i++)
        sum += number[i] - '0';
    
    return sum;
}