// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3



//Console.WriteLine("Введите число 1");
//int number1= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число 2");
//int number2= Convert.ToInt32(Console.ReadLine());


//int max = number1;
//int min = number2;

//if (number1 > max) max = number1;
//if (number2 > max) max = number2;

//Console.Write("max = ");
//Console.WriteLine(max);
//Console.Write("min = ");
//Console.WriteLine(min);


int A = new Random().Next(-100, 100);
int B = new Random().Next(-100, 100);
int max = A;
int min = B;
if (A < B) max = B;
if (A < B) min = A;
Console.WriteLine(A);
Console.WriteLine(B);
Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);



    