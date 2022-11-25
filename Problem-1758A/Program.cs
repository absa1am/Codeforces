int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string s = Console.ReadLine();
    char[] palindrome = new char[s.Length * 2];

    for(int j = 0, k = palindrome.Length - 1; j < s.Length; j++, k--)
    {
        palindrome[j] = s[j];
        palindrome[k] = s[j];
    }

    Console.WriteLine(new string(palindrome));
}