int.TryParse(Console.ReadLine(), out int t);

for (int j = 0; j < t; j++)
{
    string digits = Console.ReadLine();
    string pi = "314159265358979323846264338327";

    int correct = 0;
    for (int i = 0, k = 0; i < digits.Length; i++, k++)
    {
        if (digits[i] == pi[k]) correct++;
        else break;
    }

    Console.WriteLine(correct);
}