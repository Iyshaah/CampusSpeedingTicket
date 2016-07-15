using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusSpeedingTicket
{
    class Program
    {
        //all students are charged an INITIAL75 dollars when ticketed
        //
        //EIGHTY7DOLLARSAND50CENTS for EVERY5MPHCLOCKEDOVER 
        //
        //FRESHMEN students receive a FIFTYDOLLARDEDEUCTION if < TWENTYMPHOVER
        //FRESHMEN, SOPHOMORE, and JUNIOR students are charged an EXTRA100DOLLARS if > TWENTYMPHOVER
        //
        //SENIOR students are charged an EXTRA50DOLLARS if < TWENTYMPHOVER
        //SENIOR students are charged an EXTRA200DOLLARS if > TWENTYMPHOVER
        //

        static void Main(string[] args)
        {
            String freshmenAnswer = "";
            String seniorAnswer = "";
            Boolean freshmenStatus = false;
            Boolean seniorStatus = false;

            String TYPEOFTICKET = "";

            Double fine = 75.00;
            Double EIGHTY7DOLLARSAND50CENTS = 87.50;
            int EVERY5MPHCLOCKEDOVER = 0;
            //Double FIFTYDOLLARDEDEUCTION = 50;
            Double speed = 0.00;
            int speedOver = 0;
            //Double EXTRA50DOLLARS = 50.00;
            //Double EXTRA200DOLLARS = 200.00;

            String freshmenLoop = "";
            String seniorLoop = "";

            String studentSpeed = "";
            String clockedStudentSpeed = "not a number";
            String speedLimit = "";
            String postedSpeedLimit = "not a number either";

            String whileLoop1 = "";

            Console.WriteLine("\n* * * * * Welcome to the Campus TRAFFIC TICKET Fine Calculator * * * * *  \n");
            Console.WriteLine("\n");
            Console.WriteLine("(1)  Select TYPE of TRAFFIC TICKET you were issued:\n");
            Console.WriteLine("\n");
            Console.WriteLine("Type P for Parking\n");
            Console.WriteLine("Type S for Speeding\n");
            Console.WriteLine("Type O for Other\n");
            Console.WriteLine("\n");
            TYPEOFTICKET = Console.ReadLine();

            while (whileLoop1 != "~")

        { 

            if (TYPEOFTICKET == "p" || TYPEOFTICKET == "P" || TYPEOFTICKET == "parking" || TYPEOFTICKET == "Parking" || TYPEOFTICKET == "PARKING")

            {
                TYPEOFTICKET = "~P";
                whileLoop1 = "~";
            }

            else if (TYPEOFTICKET == "s" || TYPEOFTICKET == "S" || TYPEOFTICKET == "speeding" || TYPEOFTICKET == "Speeding" || TYPEOFTICKET == "SPEEDING")
            {


                while (studentSpeed != "~aNum")//whileLoop2 (unfinished code)
                {
                    studentSpeed = "~aNum";
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("(ENTER NUMBERS ONLY! | DO NOT USE ANY LETTERS!)\n");
                    Console.WriteLine("(2)  Enter the SPEED at which you were CLOCKED driving:\n");
                    clockedStudentSpeed = Console.ReadLine();

                    string num = clockedStudentSpeed;

                    foreach (char c in num.ToArray())
                    {
                        if (!Char.IsDigit(c))
                        {
                            //Console.WriteLine("character " + c + " is not a number");
                            studentSpeed = "~bNum";
                        }
                    }
                //bool isNum = false;
                //while (isNum == false)//whileLoop2 
                //{
                //    Console.WriteLine("\n");
                //    Console.WriteLine("\n");
                //    Console.WriteLine("(ENTER NUMBERS ONLY! | DO NOT USE ANY LETTERS!)\n");
                //    Console.WriteLine("(2)  Enter the SPEED at which you were CLOCKED driving:\n");
                //    clockedStudentSpeed = Console.ReadLine();
                //    string test1 = clockedStudentSpeed;
                //    bool alldigits = test1.All(char.IsDigit);
                //    if (alldigits)
                //    {
                //        isNum = true;
                //    }
                //    else
                //    {
                //        isNum = false;
                //    } 


                    bool isNumber = false;
                    while (isNumber == false)//whileLoop3 
                    {

                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Console.WriteLine("(ENTER NUMBERS ONLY! | DO NOT USE ANY LETTERS!)\n");
                        Console.WriteLine("(3)  Enter the POSTED SPEED LIMIT:\n");
                        postedSpeedLimit = Console.ReadLine();
                        string test = postedSpeedLimit;
                        bool allDigits = test.All(char.IsDigit);
                        if (allDigits)
                        {
                            isNumber = true;
                        }
                        else
                        {
                            isNumber = false;
                        } 
                    }//endWhileLoop3
                }//endWhileLoop2


                //EIGHTY7DOLLARSAND50CENTS for EVERY5MPHCLOCKEDOVER 
                //
                //double x = Convert.ToDouble(stringInfo);
                double StudentSpeed = Convert.ToDouble(clockedStudentSpeed);
                double SpeedLimit = Convert.ToDouble(postedSpeedLimit);
                //speedOver = (-(int)SpeedLimit + (int)StudentSpeed);
                speedOver = ((int)StudentSpeed - (int)SpeedLimit);
                speedOver = ((int)StudentSpeed - (int)SpeedLimit);

                Console.WriteLine("\n\n\n");
                Console.WriteLine("You were driving " + speedOver + " MPH OVER the limit.\n");
                EVERY5MPHCLOCKEDOVER = speedOver / 5;
                fine += (EIGHTY7DOLLARSAND50CENTS * EVERY5MPHCLOCKEDOVER);
                Console.WriteLine("The campus fee is $87.50 for every 5 MPH over the limit.\n");
                Console.WriteLine("\nPress ENTER to continue . . .\n");
                Console.ReadLine(); 
                
                while (freshmenLoop != "~")//whileLoop4
                {
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Console.WriteLine("(4)  Are you a FRESHMAN?\n");
                        Console.WriteLine("Enter Y for Yes\n");
                        Console.WriteLine("Enter N for No\n");
                        freshmenAnswer = Console.ReadLine();
                        if (freshmenAnswer == "y" || freshmenAnswer == "Y" || freshmenAnswer == "yes" || freshmenAnswer == "Yes" || freshmenAnswer == "YES")
                        {
                            freshmenStatus = true;
                            //FRESHMEN students receive a FIFTYDOLLARDEDEUCTION if < TWENTYMPHOVER
                            //FRESHMEN (SOPHOMORE and JUNIOR) students are charged an EXTRA100DOLLARS if > TWENTYMPHOVER
                            //
                            if ((int)StudentSpeed < 20)
                            {
                                fine -= 50.00;

                            } 
                            
                            if ((int)StudentSpeed >= 20)
                            {
                                fine += 100.00;
                                
                            }
                                
                            Console.WriteLine("\n\n");
                            Console.WriteLine("\n\nSTUDENT STATUS: Freshmen\n");
                            Console.WriteLine("\nFRESHMEN receive a $50 deduction.\n");
                            freshmenLoop = "~";
                            seniorLoop = "~";//bypass seniorLoop
                        }

                        if (freshmenAnswer == "n" || freshmenAnswer == "N" || freshmenAnswer == "no" || freshmenAnswer == "No" || freshmenAnswer == "NO")
                        {

                            freshmenStatus = false;
                            freshmenLoop = "~";
                        }
                }//end freshmenWhileLoop4


                    while (seniorLoop != "~")//whileLoop5
                    { 
                        Console.WriteLine("\n");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("(5)  Are you a SENIOR?\n");
                        Console.WriteLine("Enter Y for Yes\n");
                        Console.WriteLine("Enter N for No\n");
                        seniorAnswer = Console.ReadLine();
                        if (seniorAnswer == "y" || seniorAnswer == "Y" || seniorAnswer == "yes" || seniorAnswer == "Yes" || seniorAnswer == "YES")
                        {
                            seniorStatus = true;
                            //SENIOR students are charged an EXTRA50DOLLARS if < TWENTYMPHOVER
                            //SENIOR students are charged an EXTRA200DOLLARS if > TWENTYMPHOVER
                            if ((int)StudentSpeed < 20)
                            {
                                fine += 50.00;

                            }

                            if ((int)StudentSpeed >= 20)
                            {
                                fine += 200.00;

                            }

                            Console.WriteLine("\n\n");
                            Console.WriteLine("\n\nSTUDENT STATUS: Senior\n");
                            Console.WriteLine("\nSENIORS\n- charged an extra $200 penalty if 20 or more MPH over the limit.\n");
                            seniorLoop = "~";
                        }

                        if (seniorAnswer == "n" || seniorAnswer == "N" || seniorAnswer == "no" || seniorAnswer == "No" || seniorAnswer == "NO")
                        {

                            //(FRESHMEN) SOPHOMORE and JUNIOR students are charged an EXTRA100DOLLARS if > TWENTYMPHOVER
                            //
                            if ((int)StudentSpeed >= 20)
                            {
                                fine += 100.00;

                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("\n\n\nSTUDENT STATUS: Sophomore Junior Other\n");
                            Console.WriteLine("\nSOPHOMORES JUNIORS (OTHER)\n- charged an extra $100 penalty if 20 or more MPH over the limit.\n");
                            seniorStatus = false;
                            seniorLoop = "~";
                        }
                    }//endWhileLoop5

                    whileLoop1 = "~";
                    TYPEOFTICKET = "~S";

                Console.WriteLine("YOUR SPEED: " + clockedStudentSpeed + "\n");
                Console.WriteLine("POSTED SPEED: " + postedSpeedLimit + "\n"); Console.WriteLine("\n");

            }//end elseIfSpeeding


            else if (TYPEOFTICKET == "o" || TYPEOFTICKET == "O" || TYPEOFTICKET == "0" || TYPEOFTICKET == "other" || TYPEOFTICKET == "Other" || TYPEOFTICKET == "OTHER")
            {
                whileLoop1 = "~";
                TYPEOFTICKET = "~O";
            }

            else
            {

                Console.WriteLine("Please enter a valid traffic ticket type:\nEnter P for Parking\nEnter S for Speeding\nEnter O for Other"); 
                Console.WriteLine("\n");
                TYPEOFTICKET = Console.ReadLine();
            }
                if (TYPEOFTICKET == "~P")
                {
                    Console.WriteLine("\n\nPARKING TICKET\n");
                }

                else if (TYPEOFTICKET == "~S")
                {
                    Console.WriteLine("\n\nSPEEDING TICKET\n");
                }
                     
                else if (TYPEOFTICKET == "~O")
                {
                    Console.WriteLine("\n\nTRAFFIC TICKET |  OTHER\n");
                }
            
        }//end whileLoop1    

            Console.WriteLine("Your fine is $"+fine+"\n");
            TYPEOFTICKET = Console.ReadLine();
        }



        public static bool IsNumeric(string numericText)
        {

            bool isnumber = false;
            isnumber = numericText.All(Char.IsDigit);
            return numericText.All(Char.IsDigit);

        }



        //public static bool IsNumeric(string numericText)
        //{
        //    bool isnumber = false;
        //    foreach (char c in numericText)
        //    {
        //        isnumber = char.IsNumber(c);
        //        if (isnumber == false)
        //        {
        //            isnumber = false;
        //            return false;
        //        }
        //    }
        //    isnumber = true;
        //    return true;
        //}

        //public static bool IsNumeric(string numericText)
        //{
        //    bool isnumber = false;
        //    isnumber = numericText.All(Char.IsDigit);
        //    return numericText.All(Char.IsDigit);
        //}
    }
}