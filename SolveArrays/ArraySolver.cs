using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int SumOfArray = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                SumOfArray += numbers[i];
            }
            return SumOfArray;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public double AverageEvens(int[] numbers)
        {
            int countOfEvens = 0;
            int totalOfEvens = 0;


            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    totalOfEvens += num;
                    countOfEvens += 1;
                }
            }
            if (countOfEvens == 0)
            {
                return 0;
            }
            else
            {
                double average = (double)totalOfEvens / countOfEvens;
                return average; 
            }

        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = Sum(numbers.ToArray());

            if (total % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        } 
    }
}

