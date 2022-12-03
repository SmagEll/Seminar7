// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());

int sum =0;

int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{

matrix[i,j] =new Random().Next(2,14);
Console.Write(matrix[i,j]+" ");

if (i==j)
{
sum +=matrix[i,j];
}
}
Console.WriteLine();
}
Console.Write("Сумма элементов главной диагонали равна "+sum);