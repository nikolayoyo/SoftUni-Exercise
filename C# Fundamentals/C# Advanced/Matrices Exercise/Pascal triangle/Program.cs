using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var myMatrix = new int[input][];
            myMatrix[0] = new int[1] { 1 };
            myMatrix[1] = new int[2] { 1,1 };

            for (int i = 2; i < input; i++)
            {
                var length = i + 1;
                myMatrix[i] = new int[length];
                myMatrix[i][0] = 1;
                for (int j = 1; j <= length/2; j++)
                {
                    myMatrix[i][j] = myMatrix[i][j - 1] + i;
                }

                if (length%2==0)
                {

                }
                for (int j = length- length/2; j < length; j++)
                {
                    myMatrix[i][j] = myMatrix[i][j - 1] - i;
                }
            }
        }
    }
}
