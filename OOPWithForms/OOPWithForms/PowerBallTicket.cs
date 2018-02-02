using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithForms
{
    public class PowerBallTicket
    {
        public static int TICKET_PRICE = 2;

        private int[] whiteBalls;
        public int RedBall { get; private set; }

        public PowerBallTicket(int[] numbers) : this(numbers[0], numbers[1], numbers[2],
                numbers[3], numbers[4], numbers[5])
        {
            if ( numbers.Length != 6)
            {
                throw new ArgumentException("Must provide 6 numbers");
            }            
        }

        public PowerBallTicket(int first, int second, int third, int fourth, int fifth, int powerball)
        {
            if ( powerball > 26 || powerball < 1 )
            {
                throw new ArgumentException("Powerball must be between 1 and 26");
            }

            whiteBalls = new int[] { first, second, third, fourth, fifth };

            for( int index = 0; index < whiteBalls.Length; index++ )
            {
                if ( whiteBalls[index] < 1 || whiteBalls[index] > 69 )
                {
                    throw new ArgumentException("White balls must be between 1 and 69");
                }
            
                for ( int checkIndex = index +1; checkIndex < whiteBalls.Length; checkIndex++ )
                {
                    if ( whiteBalls[index] == whiteBalls[ checkIndex] )
                    {
                        throw new ArgumentException("White balls may not repeat");
                    }
                }
            }

            RedBall = powerball;
        }

        public int getWinnings( PowerBallTicket winningTicket )
        {
            int winnings = 0;

            bool redMatch = RedBall == winningTicket.RedBall;

            int whiteMatches = 0;

            foreach( var number in whiteBalls )
            {
                foreach( var winningNumber in winningTicket.whiteBalls )
                {
                    if ( number == winningNumber )
                    {
                        whiteMatches++;
                    }
                }
            }

            if ( whiteMatches == 5 && redMatch )
            {
                winnings = 1000000000;
            }
            else if (whiteMatches == 5)
            {
                winnings = 1000000;
            }
            else if (whiteMatches == 4 && redMatch)
            {
                winnings = 50000;
            }
            else if ( ( whiteMatches == 4 ) ||
                    ( whiteMatches == 3 && redMatch ) )
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

            foreach( var number in whiteBalls )
            {
                result += number.ToString() + " ";
            }

            result += RedBall.ToString();

            return result;
        }
        
    }
}
