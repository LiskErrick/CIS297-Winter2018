using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithForms
{
    public class PowerBallTicket : IComparable
    {
        public static int TICKET_PRICE = 2;

        private int[] whiteBalls;
        public int RedBall { get; private set; }

        public PowerBallTicket(IRandom random)
        {
            List<int> balls = new List<int>();

            balls.Add(random.Next(1, 70));

            while (balls.Count != 5)
            {
                var possibleBall = random.Next(1, 70);
                if (!balls.Contains(possibleBall))
                {
                    balls.Add(possibleBall);
                }
            }

            RedBall = random.Next(1, 27);
            whiteBalls = balls.ToArray();
        }
       

        public PowerBallTicket(int[] numbers) : this(numbers[0], numbers[1], numbers[2],
                numbers[3], numbers[4], numbers[5])
        {
            if (numbers.Length != 6)
            {
                throw new ArgumentException("Must provide 6 numbers");
            }
        }

        public PowerBallTicket(int first, int second, int third, int fourth, int fifth, int powerball)
        {
            if (powerball > 26 || powerball < 1)
            {
                throw new ArgumentException("Powerball must be between 1 and 26");
            }

            whiteBalls = new int[] { first, second, third, fourth, fifth };

            for (int index = 0; index < whiteBalls.Length; index++)
            {
                if (whiteBalls[index] < 1 || whiteBalls[index] > 69)
                {
                    throw new ArgumentException("White balls must be between 1 and 69");
                }

                for (int checkIndex = index + 1; checkIndex < whiteBalls.Length; checkIndex++)
                {
                    if (whiteBalls[index] == whiteBalls[checkIndex])
                    {
                        throw new ArgumentException("White balls may not repeat");
                    }
                }
            }

            RedBall = powerball;
        }

        public int getWinnings(PowerBallTicket winningTicket)
        {

            // this would be better as static variables, 
            //  but, anonymous is cool
            var prizes = new
            {
                Jackpot = 1000000000,
                FiveWhite = 1000000
            };


            int winnings = 0;

            bool redMatch = RedBall == winningTicket.RedBall;

            int whiteMatches = 0;

            foreach (var number in whiteBalls)
            {
                foreach (var winningNumber in winningTicket.whiteBalls)
                {
                    if (number == winningNumber)
                    {
                        whiteMatches++;
                    }
                }
            }

            if (whiteMatches == 5 && redMatch)
            {
                winnings = prizes.Jackpot;
            }
            else if (whiteMatches == 5)
            {
                winnings = prizes.FiveWhite;
            }
            else if (whiteMatches == 4 && redMatch)
            {
                winnings = 50000;
            }
            else if ((whiteMatches == 4) ||
                    (whiteMatches == 3 && redMatch))
            {
                winnings = 100;
            }
            else if ((whiteMatches == 3) ||
                    (whiteMatches == 2 && redMatch))
            {
                winnings = 7;
            }
            else if (redMatch)
            {
                winnings = 4;
            }

            return winnings;
        }

        public override string ToString()
        {
            // string + is bad, but let's just live with it for now

            var result = "";

            foreach (var number in whiteBalls)
            {
                result += number.ToString() + " ";
            }

            result += RedBall.ToString();

            return result;
        }

        public int CompareTo(object obj)
        {
            PowerBallTicket other = obj as PowerBallTicket;
            if ( other == null )
            {
                return -1;
            }

            List<int> myWhiteBalls = new List<int>();
            myWhiteBalls.AddRange(whiteBalls);
            myWhiteBalls.Sort();

            List<int> otherWhiteBalls = new List<int>();
            otherWhiteBalls.AddRange(other.whiteBalls);
            otherWhiteBalls.Sort();

            for ( int index = 0; index < myWhiteBalls.Count; index++)
            {
                if ( myWhiteBalls[index] < otherWhiteBalls[index] )
                {
                    return -1;
                }
                else if (myWhiteBalls[index] > otherWhiteBalls[index] )
                {
                    return 1;
                }
            }

            return RedBall - other.RedBall;

        }
    }
}
