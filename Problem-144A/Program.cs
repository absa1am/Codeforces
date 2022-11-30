int.TryParse(Console.ReadLine(), out int n);
string[] heights = Console.ReadLine().Split(' ');

int maxIndex = 0, minIndex = 0;
for(int i = 0; i < n; i++)
{
    if(int.Parse(heights[i]) > int.Parse(heights[maxIndex])) maxIndex = i;
    if(int.Parse(heights[i]) <= int.Parse(heights[minIndex])) minIndex = i;
}

if(minIndex < maxIndex) minIndex++;

Console.WriteLine(maxIndex - minIndex + n - 1);
