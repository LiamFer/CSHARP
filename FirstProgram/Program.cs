using FirstProgram;
using System;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //// Variables
        //int? x = 90;
        //double? y = 9.56;
        //bool status = false;
        //char character = '$';
        //string? nome = "asdasd";
        //// A constant variable cannot be changed in the future, its constant afterall
        //const double pi = 3.141516;
        //Console.WriteLine(nome + character + status + y + x);

        //// Type Casting
        //int ycon = Convert.ToInt32(y);
        //double xcon = Convert.ToDouble(x);

        ////Hypotenuse calculator
        //Random r = new Random();
        //// Generating two random values
        //int a = 5;
        //int b = 12;
        //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        //Console.WriteLine($"The Hypotenuse of {a} and {b} is {c}!");

        //string test = "testing_split_method";
        //string[] words = test.Split("_");

        //for (int i = 0; i < words.Length;i++)
        //{
        //    Console.WriteLine(words[i]);
        //}

        //foreach(var word in words)
        //{
        //    Console.WriteLine(word);
        //}

        //Console.WriteLine("What's the Temperature outside?");
        //double temp = Convert.ToDouble(Console.ReadLine());
        //string result = temp >= 24 ? "Hot" : "Cold";
        //Console.WriteLine($"It's really {result} outside dude.");


        // Building a triangle using nested loops
        //Console.WriteLine("Input the Triangle Height:");
        //int Theight = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Here's your Triangle fella:\n");
        //for (int i = 1; i<=Theight;i++)
        //{
        //    string row = "";
        //    for (int j = 1;j <= i; j++)
        //    {
        //        row += "@";
        //    }
        //    Console.WriteLine(row);
        //}

        // Building a Number Guessing game
        //Random random = new Random();
        //int min = 0;
        //int max = 100;
        //int chances = 10;
        //int guessNumber = random.Next(min, max);

        //while(chances > 0)
        //{
        //    Console.WriteLine("Guess the number:");
        //    int guess = Convert.ToInt16(Console.ReadLine());

        //    if(guess >= guessNumber)
        //    {
        //        Console.WriteLine("It's a little less!");
        //    } else
        //    {
        //        Console.WriteLine("It's a little more dude..");
        //    }

        //    if(guess == guessNumber)
        //    {
        //        Console.WriteLine($"Yes, {guess} is the right number! Congrats!");
        //        chances = 1;
        //        break;
        //    } else
        //    {   
        //        chances--;
        //        if (chances == 0) { break; }
        //        Console.WriteLine($"You still have {chances} tries");
        //    }
        //}
        //if (chances > 0) {
        //    Console.WriteLine("You lost!"); 
        //} else
        //{
        //    Console.WriteLine($"The right number was {guessNumber}");
        //}

        // Building a Rock, Paper, Scissors game

        //    Random random = new Random();
        //    string[] choices = { "Rock", "Paper", "Scissors"};
        //    Console.WriteLine("Choose one: ");
        //    string playerPick = Console.ReadLine();

        //    if (choices.Any(x => x.Equals(playerPick)))
        //    {
        //        string botPick = choices[random.Next(choices.Length)];
        //        string[,] options = { {"Rock","Paper"},{"Scissors", "Rock" },{"Paper","Scissors"}};
        //        Console.WriteLine($"{playerPick} X {botPick}!");
        //        if (playerPick.Equals(botPick)) {
        //            Console.WriteLine("We're even brother!");
        //        } else
        //        {
        //            for(int i = 0;i < options.Length; i++)
        //            {
        //                Console.WriteLine(options);
        //            }

        //            foreach(var option in options)
        //            {
        //                if(option.Any(e => e.Equals(playerPick)) && option.Any(e => e.Equals(botPick)))
        //                {
        //                   string winner = option[1].Equals(playerPick) ? "Player" : "Bot";
        //                   Console.WriteLine($"The {winner} is the Winner!");
        //                }
        //            }
        //        }
        //    } else
        //    {
        //        Console.WriteLine($"{playerPick} isn't a valid option!");
        //    }

        //    Console.ReadKey();

        // Building a Simple Calculator
        //Console.Write("Type the first number: ");
        //int firstnum = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Type the second number: ");
        //int secondnum = Convert.ToInt32(Console.ReadLine());

        //string ops = "";

        //while(ops != "sum" && ops!= "sub" && ops != "div" && ops != "times")
        //{
        //    Console.Write("Which Operation would you like to perform (sum,sub,div,times): ");
        //    ops = Console.ReadLine().ToLower();
        //}

        //switch (ops)
        //{
        //    case "sum":
        //        Console.WriteLine($"{firstnum} + {secondnum} is equal to {firstnum + secondnum}");
        //        break;
        //    case "sub":
        //        Console.WriteLine($"{firstnum} - {secondnum} is equal to {firstnum - secondnum}");
        //        break;
        //    case "div":
        //        Console.WriteLine($"{firstnum} / {secondnum} is equal to {firstnum / secondnum}");
        //        break;
        //    case "times":
        //        Console.WriteLine($"{firstnum} X {secondnum} is equal to {firstnum * secondnum}");
        //        break;
        //}

        // Implementing classes

        //Vehicle[] vehicles = new Vehicle[3];

        //vehicles[0] = new Car ("Chevy", 1998);
        //vehicles[1] = new Boat("John Deere", 2015);
        //vehicles[2] = new Motorcycle("Harley Davidson", 2022);

        //Car car = new Car("Chevy", 1998);
        //Boat boat = new Boat("John Deere", 2015);
        //Motorcycle bike = new Motorcycle("Harley Davidson",2022);

        // Lists use more memory 
        List<Vehicle> list = new();

        list.Add(new Car("Chevy", 1998));
        list.Add(new Boat("John Deere", 2015));
        list.Add(new Motorcycle("Harley Davidson", 2022));

        printItems(list);

    }

    // Generic methods
    public static void printItems<Type>(List<Type> myList)
    {
        foreach(Type item in myList)
        {
            Console.WriteLine(item.ToString());
        }
    }
}