//Программа выводит третью цифру выданного числа, или объявляет что ее нет.
//int num = new Random().Next(100000);

Console.WriteLine("Введите число:"); 
int num = int.Parse(Console.ReadLine()!);

if(num < 100){
int num1 = num;
Console.WriteLine($"{num} => Третьей цифры нет");
}

if(num < 1000){
int num2 = num % 10;
Console.WriteLine($"{num} => {num2}");
}

if(num < 10000){
int num3 = num / 10 % 10;
Console.WriteLine($"{num} => {num3}");
}

else{
int num3 = num / 100 % 10;
Console.WriteLine($"{num} => {num3}");
}

