long.TryParse(Console.ReadLine(), out long n);

if(n % 2 == 0) Console.WriteLine(n / 2);
else Console.WriteLine((- n - 1) / 2);