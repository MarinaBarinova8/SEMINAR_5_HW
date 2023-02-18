// Задача 34. Задайте массив, заполненный случайными положительными
// трехзначнымичислами. Напишите программу, которая покажет количество четных чисел в массиве
//[345,897,568,234]-> 2


int []  CreatNewArray (int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for(int i = 0; i <size; i++)
    {
        array [i] = new Random().Next(minVal,maxVal+1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 void EnenNum (int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        
        if (array [i] % 2 == 0 &&  array [i] >100)
        {
            count++;
        }
        
    }
    Console.WriteLine($"-> {count} even");
}
int [] Array = CreatNewArray(5,100,999);

ShowArray(Array);
EnenNum(Array);
