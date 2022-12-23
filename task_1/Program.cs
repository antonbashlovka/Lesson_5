/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/



void printArray(int[] arr){
    string res = "[";
    foreach (double value in arr ){
        res = res + Convert.ToString(value) + ", ";
    }
    res = res.TrimEnd(new Char[] {',', ' '}) + "]";

    Console.WriteLine(res);
}

int countEvenNums(int[] arr)
{
    int count = 0;
    foreach(int val in arr)
    {
        if (val % 2 == 0){ 
            count++;
        }
    }
    return count;
}
int[] fillArray(int[] arr){

    Random rand = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 999);
    }

    return arr;
}


int[] array = new int[10];

array = fillArray(array);

printArray(array);

Console.WriteLine(countEvenNums(array)); 