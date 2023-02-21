// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите от 1 до 4");
int i = Convert.ToInt32(Console.ReadLine());

switch(i)
{

case 1:
Console.WriteLine("[x и у от одного до бесконечности]");
break;
case 2:
Console.WriteLine("x от минус одного до бесконечности и у от одного до бесконечности ");
break;
case 3:
Console.WriteLine("х от минус одного до бесконечности и у от минус одного до бесконечности");
break;
case 4:
Console.WriteLine("х от одного до бесконечности и у от минус одного до бесконечности");
break;

default:
Console.WriteLine("Некорректное число");
break;
}