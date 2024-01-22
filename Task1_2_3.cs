// // Задача 1: 
// // Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true) {
//     Console.Write("Введите целое число или 'q' для выхода: ");
//     string input = Console.ReadLine();
//     // Проверка на выход из программы
//     if (input == "q" || input == "Q") {
//         Console.WriteLine("Программа завершена.");
//         break;
//     }
    
//     int number; 
//     if (int.TryParse(input, out number)){
//         int digitSum = CalculateDigitSum(number);
//         if (digitSum % 2 == 0) {
//             Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
//             break;
//         }    
//     }   
// else {
//     Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
//     }
// }

// int CalculateDigitSum(int num) {
// int sum = 0;
// while (num != 0) {
//     sum += num % 10;
//     num /= 10;
//     }
//     return sum;
// }


//Задача 2: 
//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateRandomArray(int size, int min, int max) {
    int [] array = new int [size];
    for(int i = 0; i < size; i++) {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int [] array){
    foreach(int e in array){
        Console.Write($"{e} ");
    }
}
Console.WriteLine();


// void SumEvenNumbers(int [] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] %2 == 0){
//             count++;
//         }   
//     }
//     Console.WriteLine($"Количество чётных чисел в массиве: {count}");
// }


// Console.Clear();
// Console.WriteLine("Введите размер массива: ");
// int size1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное трехзначное число элемента: ");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное трёхзначное число элемента: ");
// int max1 = Convert.ToInt32(Console.ReadLine());


// if(min1<max1 && min1 >= 100 && max1 <= 999) {
//     int [] newArray = CreateRandomArray(size1, min1, max1);
//     ShowArray(newArray);
//     Console.WriteLine();
//     SumEvenNumbers(newArray);
// }
// else {
//     Console.WriteLine("Для данного массива допустимы только трехзначные числа. Начните сначала.");
// }

// Задача 3: 
// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.

// !!! Для проверки введите обратно строки 41-54!!!

Console.Clear();
Console.WriteLine("Введите размер массива, не более 8: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число элемента от 0 до 9: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число элемента от 0 до 9: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int NumberFromArray(int[] array) {
    int fullNumber = 0;
    for(int i = 0; i < N; i++) {
        fullNumber = fullNumber * 10 + array[i];
    }
    return fullNumber;
 }


if(min1 <= 9 && max1 <= 9 && min1 <= max1) {
    int [] newArray = CreateRandomArray(N, min1, max1);
    ShowArray(newArray);
    Console.WriteLine();
    int arrayToNumber = NumberFromArray(newArray);
    Console.WriteLine(arrayToNumber);
}
else {
    Console.WriteLine("Не выполнены условия ввода элементов массива. Начните сначала.");
}