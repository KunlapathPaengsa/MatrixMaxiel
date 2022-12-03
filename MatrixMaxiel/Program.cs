using MatrixMaxiel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
//using System.IO;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
//var column = 3;
//int[] data = { 1, 2, 3, 4, 5, 6 };
//int[] data = { 1, 2, 3, 4, 5, 6, 7 };
var data = Enumerable.Range(1, 6).ToArray();
//int[][] jaggedArray = new int[2][];
int width = 720, height = 576;

var testMatrix = new Matrix<int>(3, data);

var resultBitmap = GenerateRandomImage();

//var resultMatrix = testMatrix.ToMatrix();

//DisplayMatrix();
DisplayBitmap();

stopWatch.Stop();
Console.Write(stopWatch.ElapsedMilliseconds);
Console.Write(" Milliseconds");


void DisplayMatrix()
{
    for (int i = 0; i < testMatrix.Row; i++)
    {
        for (int j = 0; j < testMatrix.Column; j++)
        {
            //Console.Write(resultMatrix[i, j]);
            if (j < testMatrix.Column - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Dim({testMatrix.Row},{testMatrix.Column})");
}

//void GenerateRandomImage()
Bitmap GenerateRandomImage()
{
    //int width = testMatrix.Column * 200, height = testMatrix.Row * 200;

    //bitmap
    Bitmap bmp = new Bitmap(width, height);

    //random number
    Random rand = new Random();

    //create random pixels
    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            if ((x > 100 && x < 200) && (y > 100 && y < 200))
            {

                //generate random ARGB value
                int a = rand.Next(256);
                int r = rand.Next(256);
                int g = rand.Next(256);
                int b = rand.Next(256);

                //set ARGB value
                bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
            }
        }
    }


    //load bmp in picturebox1
    //pictureBox1.Image = bmp;

    //save (write) random pixel image
    bmp.Save("C:\\Users\\Maxiel\\Pictures\\RandomImageMatrix.png", ImageFormat.Jpeg);

    return bmp;

}
void DisplayBitmap()
{
    for (int j = 0; j < height; j++)
    {
        for (int i = 0; i < width; i++)
        {
            Console.Write($"({i}, {j})");
        }
        Console.WriteLine(" | ");
    }
    Console.WriteLine($"Dim({testMatrix.Row},{testMatrix.Column})");
}