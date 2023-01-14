Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
{
    if (dayNumber == 1)
    Console.WriteLine("This day is a Monday");
}
{
    if (dayNumber == 2)
    Console.WriteLine("This day is a Tuesday");
}
{
    if (dayNumber == 3)
    Console.WriteLine("This day is a Wednesday");
}
{
    if (dayNumber == 4)
    Console.WriteLine("This day is a Thursday");
}
{
    if (dayNumber == 5)
    Console.WriteLine("This day is a Friday");
}
{
    if (dayNumber == 6)
    Console.WriteLine("This day is a Saturday");
}
{
    if (dayNumber == 7)
    Console.WriteLine("This day is a Sunday");
}
{
    if (dayNumber > 7)
    Console.WriteLine("This is not day of the week ");
}
