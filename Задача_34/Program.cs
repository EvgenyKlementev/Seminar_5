//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] array = new int [8]; // определяем новый массив

void FillArray(int[] collection)     // создаем метод случайного заполнения массива
{
    int length= collection.Length; // задаем длину массива
    int index= 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 999); // задаем диапазон случайных чисел
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    
    while (position < count)
    {
        Console.Write($"{array[position]} ");  // печать массива
        position++;
    } 

}

void PrintCount(int[] count)
{
    uint result=0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)//проверка на четность
         {
            result++;
         }
    }
    Console.WriteLine($"количество четных чисел : {result}");

}

FillArray(array); // вызываем метод заполнения
PrintArray(array);  // вызываем метод печати массива
PrintCount(array);  // вызываем метод печати счетика положительных чисел