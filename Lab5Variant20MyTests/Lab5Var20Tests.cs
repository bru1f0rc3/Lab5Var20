using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5Var20;

namespace Lab5Variant20MyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1Matrix_Enter_1_to_4_Return4_45()
        {
            double[,] matrix = new double[,]
            {
                { 1, 2, 1, 1, 5, 1, 1, 4, 3, 1 },
                { 2, 2, 3, 2, 1, 1, 1, 1, 3, 2 },
                { 4, 2, 3, 4, 5, 2, 1, 4, 1, 3 },
                { 1, 2, 3, 4, 5, 5, 1, 2, 3, 1 },
                { 1, 2, 5, 5, 5, 2, 2, 2, 1, 5 },
                { 1, 1, 5, 4, 1, 1, 1, 1, 3, 6 },
                { 1, 1, 3, 4, 5, 1, 3, 4, 6, 4 }
            };
            double expected = 4.458050224128E+22;
            double actual = Variant20.Task1(matrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1Matrix_Enter_2_to_71_Return_8_50()
        {
            double[,] matrix = new double[,]
            {
                { 2, 2, 1, 1, 5, 1, 1, 4, 3, 1 },
                { 2, 1, 3, 4, 1, 2, 3, 1, 3, 5 },
                { 2, 2, 3, 4, 5, 2, 1, 4, 1, 3 },
                { 1, 2, 3, 7, 5, 3, 3, 2, 3, 1 },
                { 3, 2, 5, 1, 5, 2, 2, 2, 1, 5 },
                { 1, 1, 5, 1, 1, 1, 1, 1, 3, 1 },
                { 4, 1, 3, 1, 5, 1, 3, 4, 6, 71 }
            };
            double expected = 9.34727749337088E+23;
            double actual = Variant20.Task1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1Matrix_Enter_5_to_61_Return_8_50()
        {
            double[,] matrix = new double[,]
            {
                { 5, 2, 1, 1, 5, 1, 1, 4, 3, 1 },
                { 2, 1, 3, 4, 1, 2, 3, 1, 3, 5 },
                { 2, 2, 3, 4, 5, 2, 1, 4, 1, 3 },
                { 1, 2, 3, 7, 5, 3, 3, 2, 3, 1 },
                { 3, 2, 5, 1, 5, 2, 2, 2, 1, 5 },
                { 1, 1, 5, 1, 1, 1, 1, 1, 3, 1 },
                { 4, 1, 3, 1, 5, 1, 3, 4, 6, 61 }
            };
            double expected = 2.00768988413952E+24;
            double actual = Variant20.Task1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1Matrix_Enter_8_to_42_Return_2_85()
        {
            double[,] matrix = new double[,]
            {
                { 8, 2, 1, 1, 5, 1, 1, 4, 2, 1 },
                { 2, 1, 2, 1, 1, 2, 5, 1, 5, 2 },
                { 2, 2, 2, 1, 1, 2, 1, 4, 1, 3 },
                { 1, 2, 5, 5, 1, 3, 1, 2, 3, 1 },
                { 1, 2, 5, 1, 1, 2, 5, 4, 2, 5 },
                { 1, 2, 4, 2, 6, 5, 2, 2, 5, 1 },
                { 1, 1, 2, 1, 5, 1, 2, 1, 2, 42 }
            };
            double expected = 2.8538044416E+21;
            double actual = Variant20.Task1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task1Matrix_Enter_9_to_58_Return_1_66()
        {
            double[,] matrix = new double[,]
            {
                { 9, 5, 1, 1, 5, 1, 1, 4, 2, 1 },
                { 2, 1, 5, 1, 1, 2, 5, 1, 5, 2 },
                { 2, 2, 2, 1, 1, 2, 1, 4, 6, 3 },
                { 1, 2, 5, 5, 1, 2, 1, 2, 3, 1 },
                { 1, 5, 5, 1, 1, 6, 5, 4, 2, 5 },
                { 1, 2, 4, 2, 6, 5, 2, 2, 5, 1 },
                { 1, 1, 4, 1, 5, 1, 2, 1, 2, 58 }
            };
            double expected = 1.6625958912E+24;
            double actual = Variant20.Task1(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2Matrix_Enter_4_7_2_8_3_6_1_5_9_10_Return_10()
        {
            double[,] matrix = new double[,]
            {
            { 4, 7, 2, 8, 3, 6, 1, 5, 9, 10 },
            { 2, 3, 6, 5, 1, 4, 8, 10, 7, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
            { 5, 10, 7, 4, 1, 2, 3, 6, 9, 8 },
            { 6, 1, 8, 3, 10, 7, 2, 5, 4, 9 },
            { 7, 6, 9, 2, 5, 4, 1, 10, 8, 3 }
            };
            double expected = 10;
            double actual = Variant20.Task2(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2Matrix_Enter_4_9_2_8_3_7_1_6_5_10_8_3_Return_10()
        {
            double[,] matrix = new double[,]
            {
                { 4, 9, 2, 8, 3, 7, 1, 6, 5, 10 },
                { 2, 3, 6, 5, 1, 4, 8, 10, 7, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                { 5, 10, 7, 4, 1, 2, 3, 6, 9, 8 },
                { 6, 1, 8, 3, 10, 7, 2, 5, 4, 9 },
                { 7, 6, 9, 2, 5, 4, 1, 10, 8, 3 }
            };
            double expected = 10;
            double actual = Variant20.Task2(matrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2Matrix_Enter_101_505_1007_777_555_25922_5955_2522_353_444_Return_25922()
        {
            double[,] matrix = new double[,]
            {
                { 9, 5, 1, 1, 5, 1, 101, 4, 2, 4 },
                { 2, 1, 5, 1, 1, 2, 505, 1, 5, 3 },
                { 2, 2, 2, 1, 1, 2, 1007, 4, 6, 2 },
                { 1, 2, 5, 5, 1, 2, 777, 2, 3, 1 },
                { 1, 5, 5, 1, 1, 6, 555, 4, 2, 67 },
                { 1, 2, 255943, 2, 6, 5, 25922, 2, 5, 88 },
                { 25922, 592, 666, 77, 888, 99, 5955, 2522, 353, 444 }
            };
            double expected = 25922;
            double actual = Variant20.Task2(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2Matrix_Enter_6764564_7543743_252534_45353_57645_96236_56234626_632623_1245125_649539_Return_56234626()
        {
            double[,] matrix = new double[,]
            {
                { 9, 5, 1, 1, 5, 1, 101, 4, 2, 4 },
                { 2, 1, 5, 1, 1, 2, 505, 1, 5, 3 },
                { 2, 2, 2, 1, 1, 2, 1007, 4, 6, 2 },
                { 1, 2, 5, 5, 1, 2, 777, 2, 3, 1 },
                { 1, 5, 5, 1, 1, 6, 555, 4, 2, 67 },
                { 1, 2, 255943, 2, 6, 5, 25922, 2, 5, 88 },
                { 6764564, 7543743, 252534, 45353, 57645, 96236, 56234626, 632623, 1245125, 649539 }
            };
            double expected = 56234626;
            double actual = Variant20.Task2(matrix);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task2Matrix_Enter_4542_4444_223_5353_675423_222_334_5664_131_2425_Return_25952()
        {
            double[,] matrix = new double[,]
            {
                { 9, 5, 1, 1, 5, 1, 101, 4, 2, 4 },
                { 2, 1, 5, 1, 1, 2, 505, 1, 5, 3 },
                { 2, 2, 2, 1, 1, 2, 1007, 4, 6, 2 },
                { 1, 2, 5, 5, 1, 2, 777, 2, 3, 1 },
                { 1, 5, 5, 1, 1, 6, 555, 4, 2, 67 },
                { 1, 2, 255943, 2, 6, 5, 25922, 2, 5, 88 },
                { 4542, 4444, 223, 5353, 675423, 222, 334, 5664, 131, 2425 }
            };
            double expected = 675423;
            double actual = Variant20.Task2(matrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3Matrix_Enter_111_222_333_Return_5040_5040_5040_5040_5040_5040_5040_5040_5040_5040()
        {
            double[,] matrix = new double[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
                { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 },
                { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },
                { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 },
                { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 }
            };
            double[] expected = new double[] { 5040, 5040, 5040, 5040, 5040, 5040, 5040, 5040, 5040, 5040 };
            double[] actual = Variant20.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3Matrix_Enter_SpecificMatrix_Return_913392711_2287853568_4250022777_6948716544_10557421875_15276957696_21338307333_29005627392_38579438079_50400000000()
        {
            double[,] matrix = new double[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 101 }
            };
            double[] expected = new double[] { 913392711, 2287853568, 4250022777, 6948716544, 10557421875, 15276957696, 21338307333, 29005627392, 38579438079, 50400000000 };
            double[] actual = Variant20.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3Matrix_Enter_SpecificMatrix_Return_5760_737280_12597120_94371840_450000000_1612431360_4743607680_12079595520_27549901440_57600000000()
        {
            double[,] matrix = new double[,]
            {
                { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 },
                { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 },
                { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 },
                { 6, 12, 18, 24, 30, 36, 42, 48, 54, 60 },
                { 8, 16, 24, 32, 40, 48, 56, 64, 72, 80 }
            };
            double[] expected = new double[] { 5760, 737280, 12597120, 94371840, 450000000, 1612431360, 4743607680, 12079595520, 27549901440, 57600000000};
            double[] actual = Variant20.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3Matrix_Enter_AllOnes_Return_AllOnes()
        {
            double[,] matrix = new double[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };
            double[] expected = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            double[] actual = Variant20.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3Matrix_Enter_SpecificMatrix_Return_913392711_2287853568_4250022777_94371840_450000000_5971553280_8770781250_12962267136_18471967542_25166647296()
        {
            double[,] matrix = new double[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 55, 54 ,56 ,58, 59, 40, 53 }
            };
            double[] expected = new double[] { 913392711, 2287853568, 4250022777, 5971553280, 8770781250, 12962267136, 18471967542, 25166647296, 22364891640, 38160000000 };
            double[] actual = Variant20.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task4Matrix_Enter_SpecificNegativeMatrix_Return_Minus3_Minus5_Minus8_Minus5_Minus4_Minus3_Minus12_Minus16_Minus32_Minus15_Minus25_Minus35_Minus45_Minus24_Minus36_Minus7_Minus28_Minus49_Minus70()
        {
            double[,] matrix = new double[,]
            {
                { 1, -3, 2, 4, -1, 6, 7, -5, 9, 10 },
                { -2, 4, 6, -8, 10, 12, 14, 16, 18, 20 },
                { 3, 6, -5, 12, 15, -4, 21, 24, -3, 30 },
                { 4, -1, -12, -16, 20, 24, 28, -32, 36, 40 },
                { 5, 10, -15, 20, -25, 30, -35, 40, -45, 50 },
                { 6, 12, 18, -24, 30, -36, 42, 48, 54, 60 },
                { -7, 14, 21, -28, 35, 42, -49, 56, 63, -70 }
            };
            double[] expected = new double[] { -3, -5, -8, -5, -4, -3, -12, -16, -32, -15, -25, -35, -45, -24, -36, -7, -28, -49, -70 };
            double[] actual = Variant20.Task4(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task4_Enter_SpectificNegativeMatrix_Return_Minus3_Minus4_Minus5_Minus6_Minus7_Minus8_Minus9_Minus10_Minus11_Minus12_Minus13_Minus14_Minus15_Minus16_Minus17_Minus18_Minus19_Minus20_Minus21_Minus34_Minus35_Minus41_Minus42_Minus44_Minus45_Minus46_Minus50_Minus55_Minus56_Minus57_Minus58_Minus59()
        {
            double[,] matrix = new double[,]
            {
                { -1, -2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { -2, -3, -4, -5, -6, -7, -8, -9, -10, -11 },
                { -12, -13, -14, -15, -16, -17, -18, -19, -20, -21 },
                { 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 },
                { 32, 33, -34, -35, 36, 37, 38, 39, 40, -41 },
                { -42, 43, -44, -45, -46, 47, 48, 49, -50, 51 },
                { 52, 53, 54, -55, -56, -57, -58, -59, 60, 61 }
            };
            double[] expected = new double[] { -3, -4, -5, -6, -7, -8, -9, -10, -11, -12, -13, -14, -15, -16, -17, -18, -19, -20, -21, -34, -35, -41, -42, -44, -45, -46, -50, -55, -56, -57, -58, -59 };
            double[] actual = Variant20.Task4(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter1_SpecificNegativeMatrix_Return_Minus55_Minus5_Minus8_Minus5_Minus4_Minus3_Minus12_Minus16_Minus55_Minus15_Minus64_Minus35_Minus41_Minus555_Minus105()
        {
            double[,] matrix = new double[,]
            {
                { 1, -55, 2, 4, 1, 6, 7, -5, 9, 10 },
                { 2, 4, 6, -8, 10, 12, 14, 16, 18, 20 },
                { 3, 6, -5, 12, 15, -4, 21, 24, -3, 30 },
                { 4, 1, -12, -16, 20, 24, 28, -55, 36, 40 },
                { 5, 10, -15, 20, -64, 30, -35, 40, 45, 50 },
                { 6, 12, 18, 24, 30, -41, 42, 48, 54, 60 },
                { -555, 14, 21, 28, 35, 42, 49, 56, 63, -105 }
            };
            double[] expected = new double[] { -55, -5, -8, -5, -4, -3, -12, -16, -55, -15, -64, -35, -41, -555, -105 };
            double[] actual = Variant20.Task4(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter_SpecificNegativeMatrix_Return_Minus55_Minus91_Minus72_Minus55_Minus777_Minus242_Minus3_Minus666_Minus16_Minus55_Minus501_Minus15_Minus64_Minus35_Minus555_Minus464_Minus777()
        {
            double[,] matrix = new double[,]
            {
                { 1, -55, 2, 4, 1, 6, 7, -91, 9, 10 },
                { 2, 4, 6, -72, 10, 12, 14, 16, 18, 20 },
                { 3, 6, -55, -777, 15, -242, 21, 24, -3, 30 },
                { 4, 1, -666, -16, 20, 24, 28, -55, 36, 40 },
                { 5, -501, -15, 20, -64, 30, -35, 40, 45, 50 },
                { 6, 12, 18, 24, 30, 41, 42, 48, 54, 60 },
                { -555, 14, 21, 28, 35, -464, 49, -777, 63, 55 }
            };
            double[] expected = new double[] { -55, -91, -72, -55, -777, -242, -3, -666, -16, -55, -501, -15, -64, -35, -555, -464, -777 };
            double[] actual = Variant20.Task4(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4_Enter3_SpecificNegativeMatrix_Return_Minus55_Minus777_Minus95_Minus8_Minus104_Minus5_Minus5523_Minus242_Minus255_Minus3_Minus601_Minus108_Minus55_Minus501_Minus15_Minus64_Minus35_Minus555_Minus464_Minus777()
        {
            double[,] matrix = new double[,]
            {
                { 1, -55, 2, 4, 1, 6, 7, -777, -95, 10 },
                { 2, 4, 6, -8, 10, 12, 14, 16, -104, 20 },
                { 3, 6, -5, -5523, 15, -242, 21, -255, -3, 30 },
                { 4, 1, -601, -108, 20, 24, 28, -55, 36, 40 },
                { 5, -501, -15, 20, -64, 30, -35, 40, 45, 50 },
                { 6, 12, 18, 24, 30, 41, 42, 48, 54, 60 },
                { -555, 14, 21, 28, 35, -464, 49, -777, 63, 55 }
            };
            double[] expected = new double[] { -55, -777, -95, -8, -104, -5, -5523, -242, -255, -3, -601, -108, -55, -501, -15, -64, -35, -555, -464, -777 };
            double[] actual = Variant20.Task4(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
