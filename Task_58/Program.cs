/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,11);
    return array;
}


void ShowArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" {array[i,j] }");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ArrayComposition(int [,] arrayA, int [,] arrayB)
{
    int j, sum=0;
    int [,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (j = 0; j < arrayA.GetLength(1); j++)
            {
                for (int k=0; k< arrayA.GetLength(1); k++)  
                arrayC[i,j]=arrayA[i,k]*arrayB[k,j]+arrayC[i,j];
            }
        }
    return arrayC;
}

int N=2; // размерность матриц
int [,] arrayA = new int[m,m];
int [,] arrayB = new int[m,m];
arrayA=FillArray(arrayA);
arrayB=FillArray(arrayB);
ShowArray(arrayA);
ShowArray(arrayB);
arrayA=ArrayComposition(arrayA, arrayB);
ShowArray(arrayA);