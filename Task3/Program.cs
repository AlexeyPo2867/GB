/*
   Является ли день недели выходным
*/

Console.Write("Input number (1..7) -> ");

string val_str = Console.ReadLine();
int digit = int.Parse(val_str);

if((digit < 1) || (digit > 7))
{
    Console.WriteLine("Неверный формат ввода");
    return;
}

if ((digit == 6) || (digit == 7)) Console.WriteLine("Да - Выходной");
else Console.WriteLine("Нет - Рабочий день");
