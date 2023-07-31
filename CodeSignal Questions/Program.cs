using System;

namespace CodeSignal_Questions
{
    class Program
    {

        //Questions in ReadMe
        public static void Main(string[] args)
        {
            //3 x 3 = 9 for area 
            char[][] matrix = {
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '0', '1', '0' }
            };

            Console.WriteLine(GetMaxSquare(matrix));
            Console.WriteLine(Equidistance());
        }

        //solution for Equidistance 
        public static int Equidistance()
        {
            int[] arr = { 1, 3, 5, 6, 7, 9 };
            int count = 0;
            int n = arr.Length;

            for (int i = 1; i < n - 1; i++)
            {
                int left = i - 1;
                int right = i + 1;

                while (left >= 0 && right < n)
                {
                    int sum = arr[left] + arr[right];

                    // Check if the middle element is the average of the other two
                    if (2 * arr[i] == sum)
                    {
                        count++;
                        left--;
                        right++;
                    }
                    // If the sum is too small, move the right pointer
                    else if (2 * arr[i] > sum)
                    {
                        right++;
                    }
                    // If the sum is too large, move the left pointer
                    else
                    {
                        left--;
                    }
                }
            }

            return count;
        }
        //Solution for get max square 
        public static int GetMaxSquare(char[][] matrix)
        {

            //check for nulls first
            if (matrix == null || matrix.Length == 0)
            {
                return 0;
            }
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            //copy new matrix with same rows and cols
            int[,] ms = new int[rows, cols];
            int maxSquareLen = 1;

            for (int i = 0; i < rows; i++)
            {
                ms[i, 0] = matrix[i][0] - '0';
                //Console.WriteLine("ms[i, 0]" , ms[i, 0]);
                //Console.WriteLine("matrix[i][0] - '0'", matrix[i][0] - '0');
                //maxSquareLen = Math.Max(maxSquareLen, ms[i, 0]);
            }

            for (int j = 0; j < cols; j++)
            {
                ms[0, j] = matrix[0][j] - '0';
                //maxSquareLen = Math.Max(maxSquareLen, ms[0, j]);
            }
            // Calculate maximum square length for remaining cells
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        ms[i, j] = Math.Min(Math.Min(ms[i - 1, j], ms[i, j - 1]), ms[i - 1, j - 1]) + 1;
                        maxSquareLen = Math.Max(maxSquareLen, ms[i, j]);
                    }
                }
            }

            var maxSquareArea = maxSquareLen * maxSquareLen;
            return maxSquareArea;
        }
    }
}

