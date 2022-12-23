/*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
    [3.3 7.76 22 2 78.67] -> 76.67
*/

void printArray(double[] arr){
    string res = "[";
    foreach (double value in arr ){
        res = res + Convert.ToString(value) + ", ";
    }
    res = res.TrimEnd(new Char[] {',', ' '}) + "]";

    Console.WriteLine(res);
}

double findMaxInArray(double[] arr)
{
    double max = arr[0];
    foreach(double val in arr)
    {
        if (val > max){ 
            max = val;
        }
    }
    return max;
}

double findMinInArray(double[] arr)
{
    double min = arr[0];
    foreach(double val in arr)
    {
        if (val < min){ 
            min = val;
        }
    }
    return min;
}

double[] fillArray(double[] arr){

    Random rand = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rand.Next(-100, 100) + rand.NextDouble()), 2);

    }

    return arr;
}

double[] array = new double[10];

array = fillArray(array);

printArray(array);

double max = findMaxInArray(array);
double min = findMinInArray(array);

Console.WriteLine(max); 
Console.WriteLine(min); 
Console.WriteLine(Math.Round(max - min, 2)); 
