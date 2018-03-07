using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the start of our calculator, i defined menu: here so we can refer to it later to  go back to the beginning of the code
            menu:
            // we are defining a variable here that we will use for our flow control and for user input, we put the variable as a long so if a user inputs a very high variable it wont crash the application
            long yeet;
            //Console.WriteLine is just used to print text, Here we are giving the user options to chose from
            Console.WriteLine("Input 1 for Addition");
            Console.WriteLine("Input 2 for Subtraction");
            Console.WriteLine("Input 3 for Similar Angle Finding");
            Console.WriteLine("Input 4 for Multiplication");
            Console.WriteLine("Input 5 for Division");
            Console.WriteLine("Input 6 for the π Multiplier");
            Console.WriteLine("Input 7 for the π Divider");
            Console.WriteLine("Input 8 for the Square Root Calculator");
            Console.WriteLine("Input 9 for Similarity Finding (On Triangles)");
            Console.WriteLine("Input 10 for Scale Factor Finding");
            //right here is where we take the user input. So when they input a number its stored in the variable "yeet" and can be used later.
            yeet = Convert.ToInt32(Console.ReadLine());
            if(yeet > 10)
            {
                Console.WriteLine("Thats An Invalid  Input!");
                goto menu;
            }
            if(yeet < 1)
            {
                Console.WriteLine("Thats an invalid input!");
                goto menu;
            }
            if (yeet == 1)
            {
                //Here we are defining the variables that the user may input, I put them as a long but if your looking to use decimals aswell you should use double or float
                long meme;
                long antimeme;
                //Requesting the user to input one number
                Console.WriteLine("Input The First Number to be Added");
                //Actually taking user input and storing it as "meme"
                meme = Convert.ToInt32(Console.ReadLine());
                //Requesting the user to input another one
                Console.WriteLine("Input The Second Number to be Added");
                //Taking User input and storing it as "Antimeme"
                antimeme = Convert.ToInt32(Console.ReadLine());
                //In this line we giving output in the console and it will say The Sum Is: (and then here it will add the numbers together, and display it)
                Console.WriteLine("The Sum Is: " + meme + antimeme);
                //Here its giving the user an option to press esc to go back to the beginning of the code.
                Console.WriteLine("Press Esc to go back to the menu");
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    // here we are referencing the menu that we defined earlier, this is also known as a case. We defined it so we can go to a certain point in the code.
                    goto menu;
                }
            }
            if(yeet == 2)
            {
                long meme;
                long antimeme;
                //here its the exact same thing but instead we are subtracting numbers
                Console.WriteLine("Input the First Number to be Subtracted");
                meme = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the Second Number to be Subtracted");
                antimeme = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The Difference is: " + (meme - antimeme));
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    goto menu;
                }
            }
            if (yeet == 3)
            {
                long meme;
                long antimeme;
                //Here i decided to do a missing angle finding calculator and I added a quiz in it.
                Console.WriteLine("Input the First Angle");
                //Taking user input and storing it as "meme"
                meme = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the Second Angle");
                //Taking another user input and storing it as antimeme
                antimeme = Convert.ToInt32(Console.ReadLine());
                //To find a missing angle of a triangle we must add the two variables together and subtract it from 180 which is what we do here
                Console.WriteLine("The Missing Angle Is: " + (180 - (meme + antimeme)));
                //Here we allow the user to either go back to the menu or do a quiz, for this instance im not going to comment out if statement to go back to the menu since ive dont this before
                Console.WriteLine("Press Esc to go back to the Menu");
                Console.WriteLine("Press O to do a quick quiz!");
                //Here we take input from the user that they pressed the key O
                if (Console.ReadKey().Key == ConsoleKey.O)
                {
                    //Here is the beginning of the new case we've created and we are  gonna define it as yeet so we can refer to it later.
                    yeet:
                    //here we are defining D to be as a variable that will hold the numbers for later
                    //We are using C for user input
                    long c;
                    long d;
                    Random rnd = new Random();
                    long b = rnd.Next(30, 120);
                    long a = rnd.Next(30, 60);
                    d = (180 - (a + b));
                    //Just simple printouts in console
                    Console.WriteLine("Time for a quick quiz");
                    //Telling the user what the angles are so they can find the missing one.
                    Console.WriteLine("The Angles Are: " + b + " And " + a + " Whats the Missing Angle?");
                    //Here is where we take the user input
                    c = Convert.ToInt32(Console.ReadLine());
                    //Here is the beginning of an if statement, we are saying here that if the user input doesnt equal that actual answer then it will do a specific operation
                    if (c != d)
                    {
                        //in this case we have it go back to the beginning so they can take a quiz again
                        Console.WriteLine("Thats the wrong answer, try again!");
                        goto yeet;
                    }
                    //Here we are saying that if the user input equals the answer then we will have them go back to the menu
                    if (c == d)
                    {
                        Console.WriteLine("Good Job Thats The Right Answer!");
                        Console.WriteLine("Press Esc to go back to the Menu");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            goto menu;
                        }
                    }
                }
            }
           if (yeet == 4)
                {
                    //Here is a basic * calculator
                    float number1;
                    float number2;
                    Console.WriteLine("Input The First Number");
                    //Once again we are taking user input
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input The Second Number");
                    //taking user input for the second variable
                    number2 = Convert.ToInt32(Console.ReadLine());
                    //multiplying the inputs
                    Console.WriteLine("The Result Is: " + number1 * number2);
                    Console.WriteLine("Press Escape to go back to the menu");
                    //allowing the user to go back to the menu
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto menu;
                    }
           }
           if (yeet == 5)
                {
                    //same thing as the * but its / this time.
                    float number1;
                    float number2;
                    Console.WriteLine("Input the First Number");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input the Second Number");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Result is: " + number1 / number2);
           }
          if (yeet == 6)
                {
                    //Here is a pi calculator where it multiplies PI and the user input
                    double pi;
                    //user input is going to be stored in "yah"
                    float yah;
                    pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286;
                    Console.WriteLine("Input the Number to be multiplied by pi");
                    //taking user input
                    yah = Convert.ToInt32(Console.ReadLine());
                    //multiplying it by Pi and giving the result
                    Console.WriteLine("The Result Is: " + pi * yah);
                    Console.WriteLine("Press Escape to go back to the menu");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto menu;
                    }
            }
                if (yeet == 7)
                {
                    double pi;
                    double yah;
                    pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286;
                    Console.WriteLine("Input the Number to be divided by pi and to divide into pi");
                    yah = Convert.ToInt32(Console.ReadLine());
                    //Dividing pi by the user input and vice versa
                    Console.WriteLine("The Result Divided by pi is: " + yah / pi);
                    Console.WriteLine("Pi divided by the number is:" + pi / yah);
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto menu;
                    }
                }
                if (yeet == 8)
                {
                    //square root calculator by using the Math.Sqrt operator
                    float input;
                    Console.WriteLine("Input the number to be Square Rooted");
                    //taking user input
                    input = Convert.ToInt32(Console.ReadLine());
                    double number1;
                    //Taking the user input and square rooting it, and storing it as number1
                    number1 = Math.Sqrt(input);
                    // displaying the result
                    Console.WriteLine("The Result is: " + number1);
                    Console.WriteLine("Press ESC to go back to the menu");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto menu;
                    }
                }
                if (yeet == 10)
                {
                    //basic scale factor calculator, it should speak for itself.
                    double a;
                    double b;
                    Console.WriteLine("Input A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input A'");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Scale Factor Is: " + a / b);
                    Console.WriteLine("Press Esc to go back to the menu");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto menu;
                    }
                }
            if (yeet == 9)
            {
                // defining the sides and answers
                float side1;
                float side2;
                float answer1;
                float side4;
                float side5;
                float answer2;
                Console.WriteLine("This is to find if triangles are similar!");
                Console.WriteLine("Triangles are similar if their angles are the same and if they have proportional sides.");
                Console.WriteLine("Input A");
                //taking user input of sides
                side1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input B");
                side2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input A'");
                side4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input B'");
                side5 = Convert.ToInt32(Console.ReadLine());
                //taking the sides and dividing eachother to find the scale factor of the different sides.
                answer1 = side1 / side4;
                answer2 = side2 / side5;
                //saying that is the answers arent the  same then to execute this code
                if (answer1 != answer2)
                {
                    Console.WriteLine("The Triangles are Not Similar, The Scale Factor for  A and A' is: " + answer1 + "and the Scale Factor for B and B' is:" + answer2);
                    Console.WriteLine("Press ESC to go back to the menu");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto menu;
                    }
                }

                //Saying that if the scale factors are the same then to execute this code
                if (answer1 == answer2)
                {
                    Console.WriteLine("The Triangles are Similar and the Scale Factor Is: " + answer1);
                    Console.WriteLine("Press ESC to go back to the menu");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        goto menu;
                    }
                }
                }
            }
        }
    }
