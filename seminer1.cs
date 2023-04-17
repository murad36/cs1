// задача 2

// System.Console.WriteLine("Видите первое число:");
//     int number1 = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Видите второе число:");
//     int number2 = int.Parse(Console.ReadLine());

// int max = 0;
// int min = 0;

// if (number1 > number2){
//     max = number1;
//     min = number2;   
// }
// else {
//     max = number2;
//     min = number1;
// }

// System.Console.WriteLine($"Максемальное число: {max}, Минимальное число: {min}");



// задача 4

// System.Console.WriteLine("Видите первое число:");
//     int number1 = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Видите второе число:");
//     int number2 = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Видите тетие число:");
//     int number3 = int.Parse(Console.ReadLine());

// int max = 0;

// if (number2 > max) {
//     max = number2;   
// }
// if (number3 > max) {
//     max = number3;
// }
// if (number1 > max) {
//     max = number1;
// }

// System.Console.WriteLine($"максемальное число: {max}");



// задача 6

// System.Console.WriteLine("Видите число:");
//      int number = int.Parse(Console.ReadLine());

// int num = number % 2;

// if (num == 0) {
//     System.Console.WriteLine("Четное");
// }
// else {
//     System.Console.WriteLine("Нечетное");
// }



// задача 8

int evenNumber = 2;

System.Console.WriteLine("Видите число:");
    int number = int.Parse(Console.ReadLine());

int evenNamber = 2;

if (number > 1) { 
    while(evenNumber <= number){
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }   
}