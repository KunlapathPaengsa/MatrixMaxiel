namespace MatrixMaxiel
{
    public partial class Matrix<T>// : MatrixOperate<T>
    {
        private int _row;
        private int _column;
        private T[] _array;

        public Matrix(int column, T[] array)
        {
            _column = column;
            _array = array;
        }

        public int Row
        {
            get
            {
                _row = _array.Length / _column;
                int fraction = _array.Length % _column;
                if (fraction > 0)
                {
                    _row = _row + 1;
                    //T[] result = new T[_array.Length + _column - fraction];
                    //_array.CopyTo(result, 0);
                    //_array = result;
                    Array.Resize(ref _array,_array.Length + _column - fraction);
                }
                return _row;
            }

            set => _row = value;
        }
        public int Column { get => _column; set => _column = value; }

    }
}
