//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int A = new Random().Next(1, 10000);
if (A % 2==0)
{
    Console.Write(A);
    Console.WriteLine("-четное");
}
else
{
     Console.Write(A);
    Console.WriteLine("-нечетное");
}
