/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


double[] array = new double [] {3.7, 22.2, 6.5, 7.8}; 

void PrintDef(double[] arrayDef)
{
    double max = arrayDef[0];
    double min = arrayDef[0];

    for (int i = 1; i < arrayDef.Length; i++)
    {
        if (arrayDef[i] > max)
        {
            max = arrayDef[i];
        }
         else if (arrayDef[i] < min)
        {
            min = arrayDef[i];
        }
    }
    double Resulte = max - min;
    Console.WriteLine($"Element max : {max} Element min: {min} Разница между элементами: {Resulte}");
      
}

 PrintDef(array);