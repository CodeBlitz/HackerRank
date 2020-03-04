using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace DiagonalDifference
{
    public class DiagonalDifferenceFunction
    {
        public static int DiagonalDifference(List<List<int>> numberMatrix)
        {        
            if (IsMatrixDiagonal(numberMatrix))
            {
                return DiagonalList(numberMatrix, DiagonalDirection.TopToBottom)
                    .Sum()
                    .AbsoluteDifference(
                    DiagonalList(numberMatrix, DiagonalDirection.BottomToTop).Sum()
                    );
            }
            else
            {
                throw new ArgumentException("Matrix must contain diagonal format.");
            }
        }

        public static bool IsMatrixDiagonal(List<List<int>> numberMatrix)
        {
            const bool NON_SQUARE_MATRIX = false;

            if (IsMatrixSquare(numberMatrix))
            {                
                return numberMatrix.Count.IsOddNumber();
            }
            else
            {
                return NON_SQUARE_MATRIX;
            }
        }

        public static bool IsMatrixSquare(List<List<int>> numberMatrix)
        {
            int rowCount = numberMatrix.Count();
            int columnCount = numberMatrix[0].Count();
            return (rowCount == columnCount);
        }

        public enum DiagonalDirection
        {
            TopToBottom = 0,
            BottomToTop = 1
        }

        public static List<int> DiagonalList(List<List<int>> numberMatrix, DiagonalDirection diagonalDirection)
        {
            const int zeroIndexAdjustment = -1;
            const int zeroStartIndex = 0;

            int maxColumnIndex = numberMatrix.Count() + zeroIndexAdjustment;

            var listDiagonalValues = new List<int>();
            
            for (int coordinate = zeroStartIndex; coordinate.IsLessThanOrEqual(maxColumnIndex); Increment(ref coordinate, 1))
            {
                if (diagonalDirection == DiagonalDirection.TopToBottom)
                {
                    listDiagonalValues.Add(numberMatrix[coordinate][coordinate]);
                }
                else
                {
                    listDiagonalValues.Add(numberMatrix[maxColumnIndex - coordinate][coordinate]);
                }                
            }

            return listDiagonalValues;
        }

        public static void Increment(ref int number, int stepValue)
        {            
            number = number + stepValue;            
        }
    }
}
