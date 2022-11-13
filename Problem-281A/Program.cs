string word = Console.ReadLine();

if(word.Length == 1) word = char.ToUpper(word[0]).ToString();
else word = char.ToUpper(word[0]) + word.Substring(1);

Console.WriteLine(word);