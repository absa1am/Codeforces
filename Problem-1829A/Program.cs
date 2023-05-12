int.TryParse(Console.ReadLine(), out int t);

for (int i = 0; i < t; i++)
{
    string m = "codeforces";
    string s = Console.ReadLine();

    int answer = 0;
    for (int j = 0; j < 10; j++)
        if (s[j] != m[j]) answer++;

    Console.WriteLine(answer);
}