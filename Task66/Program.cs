// Задача 66: Задайте значения M и N. 
// Напишите программу, которая 
// найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Одно или оба числа не натуральные. Попробуйте еще раз.");
    return;
}
int sumNumbers = SumNumbersRec(numberM, numberN);

int SumNumbersRec(int numM, int numN)
{
    if (numM < numN)
    {
        return numN + SumNumbersRec(numM, numN - 1);
    }
    else if (numM > numN)
    {
        return numN + SumNumbersRec(numM, numN + 1);
    }
    else return numM;
}
Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberM} до {numberN} включительно: {sumNumbers}");