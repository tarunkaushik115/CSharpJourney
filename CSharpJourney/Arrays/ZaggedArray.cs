using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Arrays
{
    public class ZaggedArray
    {
        public static void Run()
        {
            int[][] myArr2 = new int[3][];
            myArr2[0] = new int[] { 10, 20, 30, 40, 50 };
            myArr2[1] = new int[] { 101, 102, 103, 104 };
            myArr2[2] = new int[] { 1001, 1002, 1003 };

            for(int i = 0; i < myArr2.GetLength(0); i++)
            {
                for(int j = 0; j < myArr2[i].Length; j++)
                {
                    Console.WriteLine(myArr2[i][j] + " ");
                }
            }
        }
    }
}
