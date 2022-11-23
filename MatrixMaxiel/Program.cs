var init_i = 2;
var init_j = 3;

var matrix = new int[2, 3];

for (int i = 0; i < init_i; i++)
{
    for (int j = 0; j < init_j; j++)
    {
        matrix[i, j] = i + j;
        Console.Write(matrix[i, j]);
        if (j < init_j - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

