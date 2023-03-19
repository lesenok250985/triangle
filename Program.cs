using System;


int numberoflayer = 4;
int empty;
int number;
for (int i = 1; i <= numberoflayer; i++)
{
    for (empty = 1; empty <= (numberoflayer - i); empty++)
        Console.Write(" ");
    for (number = 1; number <= i; number++)
        Console.Write('*');
    for (number = (i - 1); number >= 1; number--)
        Console.Write('*');
    Console.WriteLine();
}