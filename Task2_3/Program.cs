//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    int c = a % b;
    Console.WriteLine($"Остаток от деления равен: {c}");
}