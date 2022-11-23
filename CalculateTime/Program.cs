using System.Diagnostics;

var t1 = new Stopwatch();
var t2 = new Stopwatch();
var t3 = new Stopwatch();

t1.Start();
var multi = 5 * 100000;
t1.Stop();


t2.Start();
var divide = 1000000 / 2;
t2.Stop();

t3.Start();
var divide3 = 1000000 / 3;
t3.Stop();


Console.Write(multi);
Console.Write(" t1 : ");
Console.Write(t1.Elapsed);
Console.WriteLine(" tick");

Console.Write(divide);
Console.Write(" t2 : ");
Console.Write(t2.Elapsed);
Console.WriteLine(" tick");

Console.Write(divide3);
Console.Write(" t3 : ");
Console.Write(t3.Elapsed);
Console.WriteLine(" tick");
