//Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0 && num < 6)
{
    System.Console.WriteLine($"{num} -> Нет");
}
if(num > 5 && num < 8)
{
    System.Console.WriteLine($"{num} -> Да");
}

