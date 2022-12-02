using MatrixMaxiel;
using System.Diagnostics;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
//int[] data = { 1, 2, 3, 4, 5, 6 };
int[] data = { 1, 2, 3, 4, 5, 6, 7 };
//var x = IEnumerator
//var column = 3;


var testMatrix = new Matrix<int>(3, data);
var resultMatrix = testMatrix.ToMatrix();


//var x = Math.PI;
DisplayMatrix();

stopWatch.Stop();
Console.Write(stopWatch.ElapsedMilliseconds);
Console.Write(" Milliseconds");


void DisplayMatrix()
{
    for (int i = 0; i < testMatrix.Row; i++)
    {
        for (int j = 0; j < testMatrix.Column; j++)
        {
            //AddMatrix(i, j);
            Console.Write(resultMatrix[i, j]);
            if (j < testMatrix.Column - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Dim({testMatrix.Row},{testMatrix.Column})");
}
