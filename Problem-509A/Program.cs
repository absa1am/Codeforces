﻿int.TryParse(Console.ReadLine(), out int n);

int[,] table = new int[n, n];

for(int i = 0; i < n; i++)
    table[0, i] = table[i, 0] = 1;

for(int i = 1; i < n; i++)
{
    for(int j = 1; j < n; j++)
        table[i, j] = table[i - 1, j] + table[i, j - 1];
}

Console.WriteLine(table[n - 1, n - 1]);