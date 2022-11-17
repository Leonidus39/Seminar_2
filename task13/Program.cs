/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.WriteLine("Введите число (для поиска третьей цифры)");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = (num/1000)%10;
int num2 = (num/100)%10;
int num3 = num%10;
if (num>99999){
    Console.WriteLine(num1);
}
if ((num>999)&&(num<=99999)){
    Console.WriteLine(num2);
}
if ((num>99)&&(num<1000)){
    Console.WriteLine(num3);
}
if (num<100){
    Console.WriteLine("Третьей цифры нет");
}

