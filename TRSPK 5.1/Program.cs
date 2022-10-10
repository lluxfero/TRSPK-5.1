﻿DayOfWeek dayOfWeek;

Console.Write("Введите номер дня недели (от 1 до 7): ");
int value = Convert.ToInt32(Console.ReadLine());

if (Enum.IsDefined(typeof(DayOfWeek), value))
{
    dayOfWeek = (DayOfWeek)value;
}
else
{
    throw new Exception("Invalid DayOfWeek value.");
}
Console.WriteLine((DayOfWeek)(value - 1));
enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }