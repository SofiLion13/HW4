// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");
GetDegreeOfNumber (numberA, numberB);

void GetDegreeOfNumber(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine(result);
}
int GetNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}
