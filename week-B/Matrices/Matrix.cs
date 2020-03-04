using System;

namespace Matrices
{
    class Matrix
    {
        int[,] data;
        int rows;
        int cols;

        public Matrix(int height, int width)
        {
            data = new int[height,width];
            rows = height;
            cols = width;
        }

        public void Randomize(int min, int max)
        {
            Random rand = new Random();
            for(int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i,j] = rand.Next(min, max);
                }
            }
        }

        public void ClearAndSetDimenstions(int row, int col)
        {
            data = new int[row, col];
            rows = row;
            cols = col;
        }

        public bool Add(Matrix m2)
        {
            if(rows != m2.rows || cols != m2.cols)
            {   
                Console.WriteLine($"Cant add 2 matrices of dimensions ({rows},{cols}) and ({m2.rows},{m2.cols})");
                return false;
            }
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i,j] += m2.data[i,j];
                }
            }
            return true;
        }

        public bool Subtract(Matrix m2)
        {
            if(rows != m2.rows || cols != m2.cols)
            {   
                Console.WriteLine($"Cant subtract 2 matrices of dimensions ({rows},{cols}) and ({m2.rows},{m2.cols})");
                return false;
            }
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i,j] -= m2.data[i,j];
                }
            }
            return true;
        }

        public void Negate(){
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i,j] *= -1;
                }
            }
        }

        public bool Multiply(Matrix m2)
        {   
            if(cols != m2.rows)
            {
                Console.WriteLine($"Can't multiply matrices when the width of the first ({cols}) doesn't match the height of the second ({m2.rows}).");
                return false;
            }
            int[,] newData = new int[rows, m2.cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < m2.cols; j++)
                {
                    int dotProd = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        dotProd += data[i,k] * m2.data[k,j];
                    }
                    newData[i,j] = dotProd;
                }
            }
            data = newData;
            rows = newData.GetLength(0);
            cols = newData.GetLength(1);
            return true;
        }

        public void Transpose()
        {
            int[,] newData = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newData[j,i] = data[i,j];
                }
            }
            data = newData;
            int temp = rows;
            rows = cols;
            cols = temp;
        }

        public override string ToString()
        {
            string dataAsString = "*".PadRight(4*cols+3, '-')+"*\n";
            for (int i = 0; i < rows; i++)
            {
                string rowAsString = "| ";
                for(int j = 0; j < cols; j++)
                {
                    rowAsString += (data[i,j] + " ").PadLeft(4, ' ');
                }
                rowAsString += " |";
                dataAsString += rowAsString + "\n";
            }
            dataAsString += "*".PadRight(4*cols+3, '-')+"*";
            return dataAsString;
        }
    }
}
