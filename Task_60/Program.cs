/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] FillArray(int [,,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                {
                array[i, j, k]= new Random().Next(10,100);
                if (CheckUnique(array, array[i,j,k])==true)
                    array[i, j, k]= new Random().Next(10,100);
                if (CheckUnique(array, array[i,j,k])==true) // при одной проверке попадаются повторы, при двух очень маловероятно
                    array[i, j, k]= new Random().Next(10,100); 
                }
    return array;
}

bool CheckUnique( int [,,] array, int digit)
{
     for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k]==digit)
                    return true;
                else return false;
            }
            return false;
}


void ShowArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($" {array[i, j, k]} ({i},{j},{k})");
            }
        Console.WriteLine();
        }
    }
}


int N = 2;
int [,,] array = new int [N,N,N];
array=FillArray(array);
ShowArray(array);