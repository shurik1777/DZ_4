// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); // Ввели число N

if(N%2 == 0)
{
    Console.WriteLine("Да чётное");
}
else
{
    Console.WriteLine("Нет не чётное");
}