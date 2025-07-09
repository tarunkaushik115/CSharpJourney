using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Arrays
{
    public class multidimension
    {
        public static void Run()
        {
            int[,] myArr = new int[3, 4] {
            {10,20,30,40 },
            { 50,60,70,80},
            {90,100,110,120}
            };

            for(int i = 0; i < myArr.GetLength(0); i++)
            {
                for(int j=0; j < myArr.GetLength(1); j++)
                {
                    Console.Write(myArr[i,j]+" ");
                }
            }


        }
    }
}
