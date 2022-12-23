/*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/

void printArray(int[] arr){
    string res = "[";
    foreach (double value in arr ){
        res = res + Convert.ToString(value) + ", ";
    }
    res = res.TrimEnd(new Char[] {',', ' '}) + "]";

    Console.WriteLine(res);
}

int countOddNumSum(int[] arr)
{
    int sum = 0;
    foreach(int val in arr)
    {
        if ((val % 2) != 0){ 
            sum = sum + val;
        }
    }
    return sum;
}

int[] fillArray(int[] arr){

    Random rand = new Random();
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 10);
    }

    return arr;
}

int[] array = new int[10];

array = fillArray(array);

printArray(array);

Console.WriteLine(countOddNumSum(array)); 
