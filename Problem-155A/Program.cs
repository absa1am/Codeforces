int.TryParse(Console.ReadLine(), out int n);
string[] points = Console.ReadLine().Split(' ');

int min, max, ans = 0;

max = min = int.Parse(points[0]);
for(int i = 1; i < points.Length; i++)
{
    int point = int.Parse(points[i]);
    
    if(point > max)
    {
        ans++;
        max = point;
    }
    else if(point < min)
    {
        ans++;
        min = point;
    }
}

Console.WriteLine(ans);