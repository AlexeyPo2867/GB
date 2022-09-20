/*
  Выводит третью цифру
 */

Console.Write("Input number -> ");

string val_str = Console.ReadLine();

int len = val_str.Length;

if (len < 3) {
    Console.WriteLine("Отсуствует третья цифра");
    return;
}

int pow = (int)Math.Pow(10, len - 3);
int pow1 = (int)Math.Pow(10, len - 3);

int val = int.Parse(val_str);

if (len == 3) {
    Console.WriteLine($"Третья цифра {val % 10}");
    return;
}

int v1 = ((val - (val % pow)) / pow) % 10;
Console.WriteLine($"Третья цифра {v1}");



