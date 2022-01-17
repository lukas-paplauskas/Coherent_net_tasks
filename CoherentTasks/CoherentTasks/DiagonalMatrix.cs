using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentTasks
{
    public class DiagonalMatrix
    {
        public int[] MatrixDiagonalElements { get; set; }
        public readonly int Size;

        public DiagonalMatrix(params int[] diagonalElements)
        {
            MatrixDiagonalElements = diagonalElements;
            Size = diagonalElements?.Length <= 0 ? 0 : diagonalElements.Length;
        }

        public int Track()
        {
            return MatrixDiagonalElements.Sum();
        }

        public override string ToString()
        {
            return " ";
        }
        //public override bool Equals(int[] otherMatrix) => MatrixDiagonalElements == otherMatrix;
    }
}
