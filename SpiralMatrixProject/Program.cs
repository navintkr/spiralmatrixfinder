// See https://aka.ms/new-console-template for more information
using SpiralMatrixProject;

Console.WriteLine("Hello, World!");

var y = new SpiralMatrixProblem();

//Starts with [1,1] and ends [6,6]
int[,] matrix = new int[,] { {  1,  2,  3,  4,  5,  6 },
                             { 20, 21, 22, 23, 24,  7 },
                             { 19, 32, 33, 34, 25,  8 },
                             { 18, 31, 36, 35, 26,  9 },
                             { 17, 30, 29, 28, 27, 10 },
                             { 16, 15, 14, 13, 12, 11 }};
//Paramerts - Actual Matrix, Number To Find & Matrix square Size
//Outout for this test = [6, 6]
int[,] output = y.SpiralOrder(matrix, 11, 6);