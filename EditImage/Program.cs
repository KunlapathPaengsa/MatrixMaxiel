using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
byte[] imgdata = File.ReadAllBytes(@"C:\Users\Maxiel\Pictures\RandomImageMatrix.png");//13472 byte

var t = GetImageFromByteArray(imgdata);

var bmp = (Bitmap)Image.FromFile(@"C:\Users\Maxiel\Pictures\RandomImageMatrix.png");

Random rand = new Random();

for (int y = 100; y < 200; y++)
{
    for (int x = 300; x < 400; x++)
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
stopWatch.Stop();

DisplayBitmap();


bmp.Save("C:\\Users\\Maxiel\\Pictures\\RandomImageMatrix2.png", ImageFormat.Jpeg);


void DisplayBitmap()
{
    //int width = 720, height = 576;
    //for (int j = 0; j < height; j++)
    //{
    //    for (int i = 0; i < width; i++)
    //    {
    //        Console.Write($"({i}, {j})");
    //    }
    //    Console.WriteLine(" | ");
    //}
    Console.Write(stopWatch.ElapsedMilliseconds);
    Console.Write(" Milliseconds");

}