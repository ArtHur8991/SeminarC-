//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


{
    int number1,number2;
    Console.WriteLine ("Ввудите два числа: ");

    number1 = Convert.ToInt32(Console.ReadLine());
    number2 = Convert.ToInt32(Console.ReadLine());

    if(number1>number2)
    {
        Console.WriteLine ("{0} Число с большим значением", number1);
        Console.WriteLine ("{0} Число с меньшим значением", number2);
    }

    else
    {
        Console.WriteLine ("{0} Число с большим значением", number2);
        Console.WriteLine ("{0} Число с меньшим значением", number1);
    }
    Console.ReadLine();
}
