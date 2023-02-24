// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void InitArray(int[] array)
{
   int length = array.Length; // Переменной передаётся значение равное длине массива
   int index = 0;
   Random rnd = new Random(); // Счётчик элементов
   while (index < length) //Цикл пока
   {
      array[index] = rnd.Next(0, 999); //Случайное заполнение первого элемента массива
      index++; // Увеличиваем счётчик элементов на 1
   }
}
void PrintArray(int [] array)
{
   for (int i = 0; i < array.Length; i++ )
   {
       Console.Write($"{array[i]},");
   }
}
InitArray(array);
PrintArray(array);