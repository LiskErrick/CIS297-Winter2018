using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //AppendToFile("test.txt", "Hello world!");
            //var primes = new Primes();
            //var primeCount = 1;
            //foreach( var prime in primes)
            //{
            //    Console.WriteLine($"{primeCount++}: {prime}");
            //}

            var binary = new BinaryString("11111111111111111111111111111111");
            Console.WriteLine(binary.ToDouble());
            Console.ReadKey();
        }

        // Question 21
        public static void AppendToFile(string filename, string contents)
        {
            using (var file2 = File.AppendText(filename))
            {
                file2.Write(contents);
            }
            // or
            var file = File.AppendText(filename);
            file.Write(contents);
            file.Close();
        }


        // Question 22

        class Primes : IEnumerable<int>
        {
            public IEnumerator<int> GetEnumerator()
            {
                int number = 2;
                while (true)
                {
                    if (isPrime(number))
                    {
                        yield return number;
                    }
                    number++;

                }
            }

            //https://github.com/EricCharnesky/CIS297-Winter2018/blob/b8ee78527f826eafe0a47313d710cd2ea64de3db/Week7/Week7/ListsWIthLambdas.cs#L45-L55
            private bool isPrime(int number)
            {
                for (int divisor = 2; divisor < Math.Ceiling(Math.Sqrt(number)); divisor++)
                { 
                    if (number % divisor == 0)
                    { 
                        return false;
                    }
                }

                return true;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        // Question 23 & 24

        class BinaryString
        {
            private string digits;
            public BinaryString(string binaryDigits)
            {
                foreach( var character in binaryDigits )
                {
                    if ( character != '0' && character != '1' )
                    {
                        throw new ArgumentException($"{character} is not a binary digit");
                    }
                }
                digits = binaryDigits;

            }

            public double ToDouble()
            {
                double sum = 0;
                int power = 0;

                for ( int index = digits.Length - 1; index >= 0; index--)
                {
                    if ( digits[index] == '1' )
                    {
                        sum += Math.Pow(2, power);
                    }
                    power++;
                }

                return sum;
            }

            public static BinaryString operator +(BinaryString left, BinaryString right)
            {
                double value = left.ToDouble();
                double otherValue = right.ToDouble();

                int sum = (int)value + (int)otherValue;
                // https://stackoverflow.com/questions/2954962/convert-integer-to-binary-in-c-sharp
                return new BinaryString(Convert.ToString(sum, 2));
            }

            // I GIVE UP
            //public BinaryString operator+ (BinaryString other)
            //{

            //    var shorterDigits = other.digits;
            //    var longerDigits = digits;

            //    if (shorterDigits.Length > longerDigits.Length )
            //    {
            //        longerDigits = other.digits;
            //        shorterDigits = digits;
            //    }

            //    string result = "";
            //    bool carry = false;
            //    for (int index = 0; index < shorterDigits.Length; index++)
            //    {
            //        var longerDigit = longerDigits[longerDigits.Length - index - 1];
            //        var shorterDigit = shorterDigits[shorterDigits.Length - index - 1];

            //        if (longerDigit == '0' && shorterDigit == '0' && !carry)
            //        {
            //            result = '0' + result;
            //        }
            //        else if (longerDigit == '1' && shorterDigit == '0' && !carry || longerDigit == '0' && shorterDigit == '1' && !carry || carry)
            //        {
            //            result = '1' + result;
            //        }
            //        else if ( longerDigit == '1' && shorterDigit == '1' )
            //        {
            //            if ( carry)
            //            {
            //                result = '1' + result;
            //            }
            //            else
            //            {
            //                result = '0' + result;
            //            }
            //            carry = true;
            //        }
            //        // WHAT THE???

            //    }


        }

    }
}
