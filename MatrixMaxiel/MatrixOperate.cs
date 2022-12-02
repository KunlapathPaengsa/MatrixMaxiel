namespace MatrixMaxiel
{
    public partial class Matrix<T>
    {
        public T[,] ToMatrix()
        {
            var matrix = new T[Row, _column];
            for (int j = 0; j < _column; j++)
            {
                for (int i = 0; i < _row; i++)
                {
                    matrix[i, j] = _array[i * _column + j];
                }
            }
            return matrix;
        }
    }
}