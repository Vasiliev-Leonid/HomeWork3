//Задача 19. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

//Console.Write("Введите число пятизначное число: ");
////int number = Convert.ToInt32(Console.ReadLine ());
//string? number = Console.ReadLine();
//void CheckingNumber(string number){
//  if (number[0]==number[4] || number[1]==number[3]){
//    Console.WriteLine($"Ваше число: {number} - палиндром.");
//  }
//  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
//}
//if (number.Length == 5){
//  CheckingNumber(number);
//}

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

//double Distance(int xa, int xb, int ya, int yb, int za, int zb){
//    double ab = Math.Sqrt ((xb-xa) * (xb-xa) + (yb-ya) * (yb-ya) + (zb-za) * (zb-za));
//    return ab;
//}
//Console.Write("Введите координату xa:  ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координату xb:  ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координату ya:  ");
//int n3 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координату yb:  ");
//int n4 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координату za:  ");
//int n5 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координату zb:  ");
//int n6 = Convert.ToInt32(Console.ReadLine());
//double result = Distance(n1, n2, n3, n4, n5, n6);
//progConsole.WriteLine($"Расстояние между точками ({n1} , {n3}, {n5}) и ({n2}, {n4}, {n6}) равно {result}");

// Задача 23. Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
//void TableCube(int n){
//    for (int i = 1; i <= n; i++){
//        Console.Write($"{i*i*i} ");
//    }
//}

//Console.WriteLine($"Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//TableCube(n);
