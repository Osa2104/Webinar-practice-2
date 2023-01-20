//выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    System.Console.WriteLine($"{num} -> нет третьего числа");
}
if(num > 100 && num < 1000)
{
    int result = num % 10;
    System.Console.WriteLine($"{num} -> {result}");
}
if(num > 1000 && num < 10000)
{
    int result = (num / 10) % 10;
    System.Console.WriteLine($"{num} -> {result}");
}
if(num > 10000 && num < 100000)
{
    int result = (num / 100) % 10;
    System.Console.WriteLine($"{num} -> {result}");
}
