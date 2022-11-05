int t = int.Parse(Console.ReadLine());
 
for(int j = 0; j < t; j++)
{
    long psum = 0, nsum = 0;
    int n = int.Parse(Console.ReadLine());
    string[] parts = Console.ReadLine().Split(' ');
 
    for(int i = 0; i < n; i++)
    {
        if(int.Parse(parts[i]) < 0) nsum += int.Parse(parts[i]);
        else psum += int.Parse(parts[i]);
    }
 
    nsum = -nsum;
    Console.WriteLine(Math.Abs(psum - nsum));
}