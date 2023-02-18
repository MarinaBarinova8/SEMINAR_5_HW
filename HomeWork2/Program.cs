// Задача 36. задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях
//[3,7,23,12]->19
//[-4,-6,89,6]->0


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
 void OddInd (int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        
        if (i % 2 == 0)
        {
            sum = sum +0;
        }
        else
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"-> {sum} odd");
}
int [] Array = CreatNewArray(5,-99,99);

ShowArray(Array);
OddInd(Array);
