using System.Diagnostics;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
var init_i = 2;
var init_j = 3;

int[] data = { 1, 2, 3, 4, 5, 6 };

var matrix = new int[2, 3];//[2, 3] 0,0 -> 1,2


//var x = Math.PI;
DisplayMatrix();

stopWatch.Stop();
Console.Write(stopWatch.ElapsedMilliseconds);
Console.Write(" Milliseconds");


void DisplayMatrix()
{
    for (int i = 0; i < init_i; i++)
    {
        for (int j = 0; j < init_j; j++)
        {
            AddMatrix(i, j);
            Console.Write(matrix[i, j]);
            if (j < init_j - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

void AddMatrix(int i, int j)
{
    matrix[i, j] = data[i* init_j + j];
}