//Программа выводит третью цифру выданного числа, или объявляет что ее нет.
//

//Console.WriteLine("Введите число:"); 
//int num = new Random().Next(100000);

Console.WriteLine("Введите число:"); 
int num = int.Parse(Console.ReadLine()!);
int num1 = num;
void ChisloTree (int num){
if (num > 1 && num < 100){
Console.WriteLine($"{num} => Третьей цифры нет");
}

if (num > 99 && num < 1000){
num1 = num % 10;
Console.WriteLine($"{num} => {num1}");
}

if (num>999 && num < 10000){
num1 = num /10 % 10;
Console.WriteLine($"{num} => {num1}");
}
else{
num1 = num /100 % 10;
Console.WriteLine($"{num} => {num1}");
}
}

 ChisloTree (num);







/*Console.WriteLine($"{num} Третьего числа нет");
}

if(num4 < 1000){
int num2 = (num4 / 1 % 10);
Console.WriteLine($"{num} => {num2}");
}

if(num < 10000){
int num3 = num / 10 % 10;
Console.WriteLine($"{num} => {num3}");
}

else{
int num3 = num / 100 % 10;
Console.WriteLine($"{num} => {num3}");
}*/

