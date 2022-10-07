//Программа выводит вторую цифру трёхзначного числа.

int num = new Random().Next(100, 999);

int num1 = num/10;
int nam2 = num1%10;

Console.WriteLine($"{num} => {nam2}");
