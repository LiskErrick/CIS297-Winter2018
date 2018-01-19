using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week2Examples
{
    class ArrayExamples
    {
        int[] scores;
        public ArrayExamples()
        {
            Random random = new Random();

            int size = random.Next(5, 30);

            scores = new int[size];

            for ( int index = 0; index < scores.Length; index++ )
            {
                scores[index] = random.Next(1, 101);
            }
        }

       public int numberOfScores()
        {
            return scores.Length;
        }

        public void printScores()
        {
            foreach ( int value in scores )
            {
                Console.WriteLine(value);
            }
        }
    }
}
