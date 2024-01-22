// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true) {
    Console.Write("Введите целое число или 'q' для выхода: ");
    string input = Console.ReadLine();
    // Проверка на выход из программы
    if (input == "q" || input == "Q") {
        Console.WriteLine("Программа завершена.");
        break;
    }
    
    int number; 
    if (int.TryParse(input, out number)){
        int digitSum = CalculateDigitSum(number);
        if (digitSum % 2 == 0) {
            Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
            break;
        }    
    }   
else {
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
    }
}

int CalculateDigitSum(int num) {
int sum = 0;
while (num != 0) {
    sum += num % 10;
    num /= 10;
    }
    return sum;
}
