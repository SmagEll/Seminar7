// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, 
// и замените эти элементы на их квадраты

Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] =new Random().Next(2,14);
Console.Write(matrix[i,j]+" ");

}
Console.WriteLine();
}
Console.WriteLine("____________");

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i%2==0 && j%2==0)
{

matrix[i,j]*= matrix[i,j];
}
Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}