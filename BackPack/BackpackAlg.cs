using System;
using System.Collections.Generic;

namespace BackPack
{
    public class BackpackAlg
    {
        private const int BACKPAACK_SIZE = 8;
        public List<Item> items;
        public readonly int[,] matrix;

        public BackpackAlg()
        {
            items = new()
            {
                new Item(1, 1),
                new Item(3, 4),
                new Item(4, 5),
                new Item(5, 7)
            };
            matrix = new int[items.Count, BACKPAACK_SIZE];
        }

        public void InitializeMatrix()
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < BACKPAACK_SIZE; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public void Compute()
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < BACKPAACK_SIZE; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        matrix[i, j] = 1;
                        continue;
                    }
                    Item currentObject = items[i];

                    if (currentObject.Weight <= j)
                    {
                        matrix[i, j] = Math.Max(currentObject.Price + matrix[i - 1, j - currentObject.Weight], matrix[i - 1, j]);
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < BACKPAACK_SIZE; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}