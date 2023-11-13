using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Create a jagged array called studentScores
                int[][] studentScores = new int[][]
                {
            new int[] {85, 92, 78},
            new int[] {90, 87, 93, 89},
            new int[] {76, 88}
                };

                // Print the scores of each student using nested loops
                for (int i = 0; i < studentScores.Length; i++)
                {
                    Console.Write($"Student {i + 1} scores: ");
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        Console.Write(studentScores[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                // Calculate the average score for all students combined
                double totalScore = 0;
                int totalScoresCount = 0;
                foreach (var student in studentScores)
                {
                    totalScore += ArraySum(student);
                    totalScoresCount += student.Length;
                }
                double averageScoreForAll = totalScore / totalScoresCount;

                Console.WriteLine($"Average score for all students combined: {averageScoreForAll:F2}");

                // Calculate the average score for each student and print the results
                for (int i = 0; i < studentScores.Length; i++)
                {
                    double averageScoreForStudent = ArraySum(studentScores[i]) / (double)studentScores[i].Length;
                    Console.WriteLine($"Average score for Student {i + 1}: {averageScoreForStudent:F2}");
                }
            }

            // Helper method to calculate the sum of an array
            static int ArraySum(int[] array)
            {
                int sum = 0;
                foreach (var item in array)
                {
                    sum += item;
                }
                return sum;
            }
        

    }
}

