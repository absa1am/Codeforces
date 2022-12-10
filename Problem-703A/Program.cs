int.TryParse(Console.ReadLine(), out int n);

int m = 0, c = 0;
for(int i = 0; i < n; i++)
{
    string[] score = Console.ReadLine().Split(' ');

    if(int.Parse(score[0]) > int.Parse(score[1])) m++;
    else if(int.Parse(score[1]) > int.Parse(score[0])) c++;
}

if(m == c) Console.WriteLine("Friendship is magic!^^");
else if(m > c) Console.WriteLine("Mishka");
else Console.WriteLine("Chris");