int.TryParse(Console.ReadLine(), out int year);

int y = year + 1;
while(!IsDistinct(y)) y++;

Console.WriteLine(y);

bool IsDistinct(int y)
{
    Dictionary<int, bool> d = new();

    do
    {
        if(d.ContainsKey(y % 10)) return false;
        d.Add(y % 10, true);
        y /= 10;
    }
    while(y > 0);

    return true;
}