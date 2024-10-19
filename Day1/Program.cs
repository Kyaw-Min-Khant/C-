using System;
namespace Day2
{
    class Condition
    {


        static void Main(string[] args)
        {
            // Human human1 = new Human();
            // human1.name = "Kyaw Kyaw";
            // human1.age = 18;
            // human1.eat();
            // human1.go();

            Human human1 = new Human("Kyaw Kyaw", 20);
            Human human2 = new Human("Zaw Zaw", 40);
            human1.eat();
            human2.go();
            // Message.Message.Hello();
            // Message.Message.Waiting();
            // Console.Write("Pls enter your age : ");
            // int age = Convert.ToInt32(Console.ReadLine());
            //if else statements
            // if (age >= 18)
            // {
            //     Console.WriteLine("You have permission to enter this site!");

            // }
            // else if (age <= 0)
            // {
            //     Console.WriteLine("Invalid age!");

            // }
            // else
            // {
            //     Console.WriteLine("You have no permission to enter this site");
            // }


            //Switch Case
            // switch (age)
            // {
            //     case 18: Console.WriteLine("You have permission to enter this site"); break;
            //     case 0: Console.WriteLine("Invalid Age"); break;
            //     default: Console.WriteLine("You have no permission to enter this site"); break;
            // }

            //While Loop
            // Console.Write("Pls Enter Your Name : ");
            // string name = Console.ReadLine();
            // while (name == "")
            // {
            //     Console.Write("Pls Enter Your Name : ");
            //     name = Console.ReadLine();
            // }
            // Console.WriteLine("Hello " + name + " !");

            //for Loop
            // Console.WriteLine("Pls Enter Row Number : ");
            // int row = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Pls Enter Col Number : ");
            // int col = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Pls Enter Special Character : ");
            // char sign = Convert.ToChar(Console.ReadLine());
            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < col; j++)
            //     {
            //         Console.Write(sign);
            //     }
            //     Console.WriteLine();
            // }

            //Number Guessing Game;
            // Random random = new Random();
            // bool playagain = true;
            // int min = 1;
            // int max = 100;
            // int guess;
            // int number;
            // int guesses;
            // string response = "";

            // while (playagain)
            // {
            //     guess = 0;
            //     guesses = 0;
            //     number = random.Next(min, max + 1);
            //     while (guess != number)
            //     {
            //         Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
            //         guess = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Guess : " + guess);
            //         if (guess > number)
            //         {
            //             Console.WriteLine(guess + " is Too High");
            //         }
            //         else if (guess < number)
            //         {
            //             Console.WriteLine(guess + " is Too Low");
            //         }
            //         guesses++;
            //     }
            //     Console.WriteLine("Number : " + number);
            //     Console.WriteLine("You Win !");
            //     Console.WriteLine("Guesses : " + guesses);
            //     Console.WriteLine("Do you want to play again? (Y/N)");
            //     response = Console.ReadLine();
            //     response = response.ToUpper();
            //     if (response == "Y")
            //     {
            //         playagain = true;
            //     }
            //     else
            //     {
            //         playagain = false;
            //     }
            // }

            // Caculator App
            // do
            // {
            //     Console.Write("Enter first Number : ");
            //     int num1 = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Enter second Number : ");
            //     int num2 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Enter symbol +-*/ : ");
            //     switch (Console.ReadLine())
            //     {
            //         case "+": Console.WriteLine("Result : " + (num1 + num2)); break;
            //         case "-": Console.WriteLine("Result : " + (num1 - num2)); break;
            //         case "*": Console.WriteLine("Result : " + (num1 * num2)); break;
            //         case "/": Console.WriteLine("Result : " + (num1 / num2)); break;
            //         default: Console.WriteLine("Invalid Symbol!"); break;
            //     }
            //     Console.WriteLine("Do you want to continue?(Y= yes, N= no)");
            // } while (Console.ReadLine().ToUpper() == "Y");

            // Method 
            // singHappyBirthday("Kyaw Kyaw", 18);
            // Console.WriteLine("---------------------------------");
            // singHappyBirthday("Su Su", 20);
            // Console.WriteLine("---------------------------------");
            // singHappyBirthday("Zaw Zaw", 26);
            // Console.WriteLine("---------------------------------");


            //Arrays
            // string[] cars = { "Toyota", "Mazada", "KIA" };
            // Console.WriteLine(cars[0]);
            // Console.WriteLine(cars[1]);
            // Console.WriteLine(cars[2]);

            // string[] newCars = new string[3];
            // newCars[0] = "Toyota";
            // newCars[1] = "Mazada";
            // newCars[2] = "KIA";
            // foreach (string car in newCars)
            // {
            //     Console.WriteLine(car);
            // }
            //     int sum1 = sum(1, 2);
            //     int sum2 = sum(3, 6);
            //     Console.WriteLine("Sum is " + sum1);
            //     Console.WriteLine("Sum is " + sum2);
            // }
            // static void singHappyBirthday(string name, int age)
            // {
            //     Console.WriteLine("Happy Birthday to you");
            //     Console.WriteLine("Happy Birthday to you!");
            //     Console.WriteLine("Happy Birthday dear! " + name);
            //     Console.WriteLine("Happy Birthday " + age + "Birthdays");
            // }
            // static int sum(int num1, int num2)
            // {
            //     int sum = num1 + num2;
            //     return sum;
            // }

        }
    }
    class Human
    {
        public string name;
        public int age;
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void eat()
        {
            Console.WriteLine($"{name} is eating");
        }
        public void go()
        {
            Console.WriteLine($"{age} {name} is going to work");
        }
    }
}

