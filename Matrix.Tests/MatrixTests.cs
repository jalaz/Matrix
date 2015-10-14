using System;
using NUnit.Framework;

namespace Matrix.Tests
{
    public class MatrixTests
    {
        //[Test]
        //public void Constructor_WhenPassedArray_ReturnsCorrectSize()
        //{
        //    var arr = new int[3, 2];
        //    var matrix = new CoolMatrix(arr);

        //    var expectedSize = new Size(width: 3, height:2);

        //    Assert.AreEqual(expectedSize, matrix.Size);
        //}

        //[Test]
        //public void Constructor_WhenPassedNull_ThrowsArgumentNullException()
        //{
        //    Assert.Throws<ArgumentNullException>(() =>
        //    {
        //        new CoolMatrix(null);
        //    });
        //}

        //[Test]
        //public void IsSquare_WithNotSquare_ReturnsFalse()
        //{
        //    CoolMatrix matrix = new int [3,2];
        //    Assert.IsFalse(matrix.IsSquare);
        //}

        //[Test]
        //public void IsSquare_WithSquare_ReturnsTrue()
        //{
        //    CoolMatrix matrix = new int[2, 2];
        //    Assert.IsTrue(matrix.IsSquare);
        //}

        //[Test]
        //public void ToString_Always_PrintsOutUnderlyingMatrix()
        //{
        //    CoolMatrix matrix = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    var expected = $@"[1, 2]{Environment.NewLine}[3, 4]";

        //    Assert.AreEqual(expected, matrix.ToString());
        //}

        //[Test]
        //public void Indexer_WhenUsed_ReturnsDataFromMatrix()
        //{
        //    CoolMatrix matrix = new [,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    Assert.AreEqual(1, matrix[0, 0]);
        //    Assert.AreEqual(2, matrix[0, 1]);
        //    Assert.AreEqual(3, matrix[1, 0]);
        //    Assert.AreEqual(4, matrix[1, 1]);
        //}

        //[Test]
        //public void Indexer_UsingValueOutOfMatrixRange_ThrowsArgumentOutOfRangeException()
        //{
        //    CoolMatrix matrix = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    Assert.Throws<IndexOutOfRangeException>(() =>
        //    {
        //        var temp = matrix[2, 0];
        //    });
        //}

        //[Test]
        //public void EqalityOperator_WhenAllMembersAreEqual_ReturnsTrue()
        //{
        //    CoolMatrix matrixA = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    CoolMatrix matrixB = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    Assert.IsTrue(matrixA == matrixB);
        //}

        //[Test]
        //public void EqualityOperator_WhenAnyMemberIsNotEqual_ReturnsFalse()
        //{
        //    CoolMatrix matrixA = new[,]
        //    {
        //        { 0, 2 },
        //        { 3, 4 }
        //    };

        //    CoolMatrix matrixB = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    Assert.IsFalse(matrixA == matrixB);
        //}

        //[Test]
        //public void MultiplyOperator_WithScalar_MultipliesEachElementByScalar()
        //{
        //    CoolMatrix matrixA = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    CoolMatrix expected = new[,]
        //    {
        //        { 2, 4 },
        //        { 6, 8 }
        //    };

        //    var result = matrixA * 2;

        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //public void AdditionOperator_AmongMatricies_AddsCorrespondingEntries()
        //{
        //    CoolMatrix matrixA = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    CoolMatrix matrixB = new[,]
        //    {
        //        { 5, 6 },
        //        { 7, 8 }
        //    };

        //    CoolMatrix expected = new[,]
        //    {
        //        { 6, 8 },
        //        { 10, 12 }
        //    };

        //    var result = matrixA + matrixB;

        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //public void AddOperator_WithMatrixesOfDifferentSize_ThrowsArgumentException()
        //{
        //    CoolMatrix matrixA = new[,]
        //    {
        //        { 1, 2 },
        //        { 3, 4 }
        //    };

        //    CoolMatrix matrixB = new[,]
        //    {
        //        { 5, 6 }
        //    };

        //    Assert.Throws<ArgumentException>(() =>
        //    {
        //        var result = matrixA + matrixB;
        //    });
        //}

        //[Test]
        //public void Transpose_Always_TransposesMatrix()
        //{
        //    CoolMatrix matrix = new[,]
        //    {
        //        { 1, 2 }
        //    };

        //    CoolMatrix expected = new[,]
        //    {
        //        { 1 },
        //        { 2 }
        //    };

        //    Assert.AreEqual(expected, matrix.Transpose());
        //}
    }
}
