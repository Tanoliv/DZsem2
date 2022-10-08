//Программа определяет  по номеру день недели и проверят является ли он выходным днем.

Console.Write("Введите число (1 - 7), обозначающее день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void NumDay (int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("Этот день выходной? -> да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("Введено не то число, смотри условие ввода");
  }
  else Console.WriteLine("(Этот день выходной? -> нет");
}

NumDay(day);


