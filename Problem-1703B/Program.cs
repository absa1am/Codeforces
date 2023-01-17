int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int[] problems = new int[26];

    int.TryParse(Console.ReadLine(), out int n);
    string solvedProblems = Console.ReadLine();

    for(int j = 0; j < n; j++)
        problems[solvedProblems[j] - 65]++;

    int balloons = 0;
    for (int j = 0; j < 26; j++)
        balloons += problems[j] > 0 ? problems[j] + 1 : 0;

    Console.WriteLine(balloons);
}