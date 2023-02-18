// Задача 38. Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементами массива
//[3.0  7.1  22.5 2.7  78.8]->76.1

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

void  NewArray ( double [] array )
{
    for(int i = 0; i <array.Length; i++)
    {
        array [i] = Convert.ToDouble(new Random().Next(100,1000) )/ 100;
    }
    
}

void ShowArray(double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
 void RealNum (double [] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    
    for(int i = 0; i < array.Length; i++)
    {
        
        if (array [i]> max)
            max =array [i];
        if (array [i]< min)
        
            min =array [i];
    }
    Console.Write($"Max {max} - ");
    
    Console.Write($"Min {min}");
    double dif = max-min;
    double newdif = Math.Round(dif, 2);
    Console.WriteLine($"-> {newdif} ");
}
Console.Write("Input count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] Array = new double[sizeArray];
NewArray(Array);
ShowArray(Array);
RealNum(Array);



