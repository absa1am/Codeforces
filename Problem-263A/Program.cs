int[,] mat = new int[5, 5];
(int a, int b) location = (0, 0);

for(int i = 0; i < 5; i++)
{
    string[] parts = Console.ReadLine().Split(' ');
    
    for(int j = 0; j < 5; j++)
    {
        mat[i, j] = int.Parse(parts[j]);
        
        if(mat[i, j] == 1) location = (i + 1, j + 1);
    }
}

Console.WriteLine(Math.Abs(3 - location.a) + Math.Abs(3 - location.b));