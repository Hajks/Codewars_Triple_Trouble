using System;

namespace Codewars_Triple_Trouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySolution
            int TripleDouble(long num1, long num2)
            {
    
                int sum1 = 0;
                int sum2 = 0;
                if (num1 > 99 && num2 > 9)
                {
                    char[] number1 = num1.ToString().ToCharArray();
                    char[] number2 = num2.ToString().ToCharArray();
                    for (int i = 1; i < number1.Length-1; i++)
                    {
                        if (number1[i] == number1[i - 1] && number1[i] == number1[i + 1])
                        {
                            sum1 += 1;
                        }
                    }
                    for (int i = 1; i < number2.Length - 1; i++)
                    {
                        if (number2[i] == number2[i - 1] ||  number2[i] == number2[i + 1])
                        {
                            sum2 += 1;
                        }
                    }
                }
                if (sum1>0 && sum2>0)
                    return 1;
                else
                    return 0;
            }
        }
        }
    }
}
