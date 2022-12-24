namespace Basic_Core_Progams
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            char cnt = '\0';

            while (true)
            {
            Menu:
                Console.WriteLine("\n***********************************************************************");
                Console.WriteLine("***********|  WEL-COME TO BASIC CORE PROGRAMS Application  |***********");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*********************  OPTIONS ARE FOLLOWING  *************************\n");
                Console.WriteLine("1:FlipCoin\n2:LeapYear\n3:PowerOfTwo\n4:Harmonics\n5:Factors\n6:QuotientAndRemainder\n7:SwapTwoNumbers\n8:EvenOddNumber\n9:VowelConsonant\n10:LargestNumber");
                Console.WriteLine("\n*************************|  END OF OPTIONS  |*************************");
                Console.Write("Enter the Option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {

                    case 1:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        FlipCoin.flipCoin();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 2:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        LeapYear.LeapYearPrgoram();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 3:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        Power.PowerOfTwoNum();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 4:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        HarmoNum.HarmonicNumber();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 5:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        Console.Write("Please enter input value : ");
                        int iNo = Convert.ToInt32(Console.ReadLine());
                        Factor.factorsNumber(iNo);
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 6:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        QuoitRem.findingQuotientNumber();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 7:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        SwapNumber.SwapTwoNumbers1();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 8:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        EvenOdd.EvenOddNumber();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 9:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        Vowels.vowelConsonant();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    case 10:
                        Console.WriteLine("\n*******************> Result <*********************\n");
                        LargestNumber.largestNumber();
                        Console.WriteLine("\n****************> End of Result <******************\n");
                        break;
                    default:
                        Console.WriteLine("Please enter right option !!!!!!!!!!!!!");
                        goto Menu;
                }
            ExitMenu:

                Console.WriteLine("\nEnter Y to Continue OR N to Exit the Application\n");
                Console.Write("(Y/N)=>\t");
                cnt = Console.ReadLine()[0];
                Console.WriteLine("\n");
                if (('Y'.Equals(cnt)) || ('y'.Equals(cnt)))
                {
                    continue;
                }
                else if (('n'.Equals(cnt)) || ('N'.Equals(cnt)))
                {
                    Console.WriteLine("**************>| THANK YOU for using this application |<***************");
                    break;
                }
                else
                {
                    Console.WriteLine("\nEnter the Proper Option !!!!!!!!!!!!!!!!!!!!!");
                    goto ExitMenu;
                }

            }
        }
    }
}