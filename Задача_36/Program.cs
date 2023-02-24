/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/



int[] array = new int [4]; 

void FillArray(int[] collection)     
{
    int length= collection.Length; 
    int index= 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-10, 10); 
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    
    while (position < count)
    {
        Console.Write($"{array[position]} "); 
        position++;
    }    
}

void PrintSum(int[] count)
{
    int resultSum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
           resultSum+=count[i];
        }
    }
    Console.WriteLine($"Сумма нечетных чисел : {resultSum}");

}

FillArray(array); 
PrintArray(array);  
PrintSum(array);  