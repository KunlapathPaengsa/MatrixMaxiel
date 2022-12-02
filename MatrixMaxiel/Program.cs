using System.Diagnostics;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
int[] data = { 1, 2, 3, 4, 5, 6 };
var column = 3;


var row = data.Length/column;
var matrix = new int[row, column];//[2, 3] 0,0 -> 1,2


//var x = Math.PI;
DisplayMatrix();

stopWatch.Stop();
Console.Write(stopWatch.ElapsedMilliseconds);
Console.Write(" Milliseconds");


void DisplayMatrix()
{
    for (int i = 0; i < data.Length / column; i++)
    {
        for (int j = 0; j < column; j++)
        {
            AddMatrix(i, j);
            Console.Write(matrix[i, j]);
            if (j < column - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

void AddMatrix(int i, int j)
{
    matrix[i, j] = data[i* column + j];
}