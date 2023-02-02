/*Задача1.Напишите программу,которая принимает на вход трёхзначное число 
и на выхое показывает вторую цифру этого числа.*/
/*
Console.WriteLine("Введите трехзначное число");
int a =Convert.ToInt32(Console.ReadLine());
if(a > 99 && a < 1000)
{
    int result = a/10%10;
    Console.WriteLine("Второе число равно " + result);
}
else
{
 Console.WriteLine("Число не трехзначное");
}
*/
/*Задача 2.Напишите программу ,которая выводит третью цифру 
заданного числа или сообщает , что третьей цифры нет.*/
/*
int InputInt(string message)
{
    System.Console.Write(message + "  ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int numIn = InputInt("Введите число:");
if (numIn / 100 == 0)
{

    Console.WriteLine("Третьей цифры нет");
}

else
{
    while (numIn > 1000)
    {
        numIn = numIn / 10;
    }
    Console.WriteLine($"Третья цифра: {numIn % 10}");
}
*/
/*Задача 3.Напишите программу,которая принимает на вход цифру,обозначающую день недели,
и проверяет , является ли этот день выходным.*/
/*
Console.Write("Введите цифру , обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
{
    if (dayNum == 6 || dayNum == 7){
        Console.WriteLine("(Этот день выходной) -> да");
    }
    else if (dayNum < 1 || dayNum > 7){
        Console.WriteLine("Это не день недели");
    }
    else Console.WriteLine("(Этот день не выходной) -> нет");
}
*/
