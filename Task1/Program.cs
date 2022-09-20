/*
   Выводит вторую цифру
*/

Console.Write("Input number -> ");
string val_str = Console.ReadLine();
int val = int.Parse(val_str);

int digits = ((val % 100) - (val % 10)) / 10;

Console.WriteLine($"Second digits: {digits}");
